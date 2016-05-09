using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace LiveSync2._0.Models
{
    class ContactGroup
    {
        Outlook.MAPIFolder Folder_Contacts;
        Outlook.Application app;
        Outlook.Folder contacts;
        Outlook.ContactsModule module;
        Outlook.NavigationGroup group;
       // group.NavigationFolders.Add(contacts.Folders.Add("Business Contacts")); // adds folders to group
    
        public ContactGroup(String groupName)
        {
            app = new Outlook.Application();
            contacts = app.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts) as Outlook.Folder;
            module = app.ActiveExplorer().NavigationPane.Modules.GetNavigationModule(Outlook.OlNavigationModuleType.olModuleContacts) as Outlook.ContactsModule;
            Outlook.NavigationGroup group = module.NavigationGroups.Create(groupName);
            group.NavigationFolders.Add(contacts.Folders.Add("Class Contacts"));
        }

        public List<Outlook.ContactItem> getContacts(string group)
        {
            List<Outlook.ContactItem> contacts = new List<Outlook.ContactItem>();
            Folder_Contacts = (Outlook.MAPIFolder)app.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            

            foreach(Outlook.ContactItem item in Folder_Contacts.Items)
            {
                contacts.Add(item);
               
            }
            return contacts;
        }
    }
}
