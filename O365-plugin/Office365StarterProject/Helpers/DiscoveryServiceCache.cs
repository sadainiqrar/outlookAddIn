﻿

using Microsoft.Office365.Discovery;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Office365Plugin.Helpers
{
    public enum ServiceCapabilities
    {
        Mail,
        Calendar,
        Contacts,
        MyFiles
    }
    public class ServiceCapabilityCache
    {
        public string UserId { get; set; }

        public CapabilityDiscoveryResult CapabilityResult { get; set; }
    }

    public class DiscoveryServiceCache
    {
        const string FileName = "DiscoveryInfo.txt";
        static ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

        public string UserId
        {
            get;
            set;
        }

        public IDictionary<string, CapabilityDiscoveryResult> DiscoveryInfoForServices
        {
            get;
            set;
        }

        public static async Task<DiscoveryServiceCache> LoadAsync()
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            try
            {
                _lock.EnterReadLock();
                StorageFile textFile = await localFolder.GetFileAsync(FileName);

                using (IRandomAccessStream textStream = await textFile.OpenReadAsync())
                {
                    using (DataReader textReader = new DataReader(textStream))
                    {
                        uint textLength = (uint)textStream.Size;

                        await textReader.LoadAsync(textLength);
                        return Load(textReader);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _lock.ExitReadLock();
            }

            return null;
        }

        public static async Task<ServiceCapabilityCache> LoadAsync(ServiceCapabilities capability)
        {
            CapabilityDiscoveryResult capabilityDiscoveryResult = null;

            DiscoveryServiceCache cache = await LoadAsync();

            cache.DiscoveryInfoForServices.TryGetValue(capability.ToString(), out capabilityDiscoveryResult);

            if (cache == null || capabilityDiscoveryResult == null)
            {
                return null;
            }

            return new ServiceCapabilityCache
            {
                UserId = cache.UserId,
                CapabilityResult = capabilityDiscoveryResult
            };
        }

        public static async Task<DiscoveryServiceCache> CreateAndSaveAsync(string userId, IDictionary<string, CapabilityDiscoveryResult> discoveryInfoForServices)
        {
            var cache = new DiscoveryServiceCache
            {
                UserId = userId,
                DiscoveryInfoForServices = discoveryInfoForServices
            };

            StorageFolder localFolder = ApplicationData.Current.LocalFolder;

            StorageFile textFile = await localFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
            try
            {
                _lock.EnterWriteLock();
                using (IRandomAccessStream textStream = await textFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    using (DataWriter textWriter = new DataWriter(textStream))
                    {
                        cache.Save(textWriter);
                        await textWriter.StoreAsync();
                    }
                }
            }
            finally
            {
                _lock.ExitWriteLock();
            }

            return cache;
        }

        private void Save(DataWriter textWriter)
        {
            textWriter.WriteStringWithLength(UserId);

            textWriter.WriteInt32(DiscoveryInfoForServices.Count);

            foreach (var i in DiscoveryInfoForServices)
            {
                textWriter.WriteStringWithLength(i.Key);
                textWriter.WriteStringWithLength(i.Value.ServiceResourceId);
                textWriter.WriteStringWithLength(i.Value.ServiceEndpointUri.ToString());
                textWriter.WriteStringWithLength(i.Value.ServiceApiVersion);
            }
        }

        private static DiscoveryServiceCache Load(DataReader textReader)
        {
            var cache = new DiscoveryServiceCache();

            cache.UserId = textReader.ReadString();
            var entryCount = textReader.ReadInt32();

            cache.DiscoveryInfoForServices = new Dictionary<string, CapabilityDiscoveryResult>(entryCount);

            for (var i = 0; i < entryCount; i++)
            {
                var key = textReader.ReadString();

                var serviceResourceId = textReader.ReadString();
                var serviceEndpointUri = new Uri(textReader.ReadString());
                var serviceApiVersion = textReader.ReadString();

                cache.DiscoveryInfoForServices.Add(key, new CapabilityDiscoveryResult(serviceEndpointUri, serviceResourceId, serviceApiVersion));
            }

            return cache;
        }
    }
}

 