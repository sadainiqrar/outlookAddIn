using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSync2._0.Models
{
    class OneDriveObject
    {
        public static OneDriveObject oneDrive;

        OneDriveLogin login;
        private OneDriveObject()
        {
            login = new OneDriveLogin();
        }

        public static OneDriveLogin ONEDRIVE
        {
            get
            {
                if (oneDrive == null)
                    oneDrive = new OneDriveObject();
                return oneDrive.login;
            }
        }
    }
}
