using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LiveSync2._0.Models
{
    class LocalFolder
    {
        public static LocalFolder folder;

        string path;

        private LocalFolder()
        {

            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(path + @"\Live Sync"))
            {
                Directory.CreateDirectory(path + @"\Live Sync");
            }

        }
        public static string FOLDER
        {
            get
            {
                if(folder == null)
                {
                    folder = new LocalFolder();
                }
                return folder.path + @"\Live Sync";
            }
            set
            {
                if (folder == null)
                {
                    folder = new LocalFolder();
                }
                folder.path = value;
            }
        }
        
    }
}
