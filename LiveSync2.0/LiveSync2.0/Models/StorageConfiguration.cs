using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LiveSync2._0.Models
{
    class StorageConfiguration
    {
        public StorageConfiguration()
        {

        }

        public void createFolder(string path)
        {
            if (!Directory.Exists(path + @"\Live Sync"))
            {
                Directory.CreateDirectory(path + @"\Live Sync");
            }
            LocalFolder.FOLDER = path;
        }
    }
}
