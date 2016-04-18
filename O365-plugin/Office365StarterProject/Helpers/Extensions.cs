
using Windows.Storage.Streams;

namespace Office365Plugin.Helpers
{
    static class Extensions
    {
        public static void WriteStringWithLength(this DataWriter w, string s)
        {
            w.WriteUInt32((uint)s.Length);
            w.WriteString(s);
        }

        public static string ReadString(this DataReader r)
        {
            return r.ReadString(r.ReadUInt32());
        }


    }
}