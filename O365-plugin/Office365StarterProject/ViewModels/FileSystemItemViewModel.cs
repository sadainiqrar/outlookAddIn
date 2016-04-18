
using Microsoft.Office365.SharePoint;
using Microsoft.Office365.SharePoint.FileServices;

namespace Office365Plugin.ViewModels
{
    /// <summary>
    /// Contains the files that are used in the view model.
    /// </summary>
    public class FileSystemItemViewModel
    {

        private IItem _fileSystemItem;
        private string _name;

        public FileSystemItemViewModel(IItem fileSystemItem)
        {
            if (fileSystemItem == null)
            {
                throw new System.ArgumentNullException("fileSystemItem");
            }

            _fileSystemItem = fileSystemItem;

            _name = fileSystemItem.Name;
        }

        public IItem FileSystemItem
        {
            get
            {
                return _fileSystemItem;
            }
            private set

            { _fileSystemItem = value; }
        }

        /// <summary>
        /// The DisplayName property is the property path used in the 
        /// DisplayMemberPath property in the ListBox control that is
        /// bound to the ViewModel.
        /// </summary>
        public string DisplayName
        {
            get
            {
                if (_fileSystemItem is Folder)
                {
                    return _name + " (folder)";
                }
                else
                {
                    return _name;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}