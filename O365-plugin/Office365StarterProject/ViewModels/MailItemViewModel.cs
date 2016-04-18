using Microsoft.Office365.OutlookServices;
using Office365Plugin.Common;
using Office365Plugin.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Data.Html;

namespace Office365Plugin.ViewModels
{
    class MailItemViewModel : ViewModelBase
    {
        private string _id;

        //Specfies the mail body as a text block consisting of multiple lines. This prevents body display
        //as a single line of text.
        [DataType(DataType.MultilineText)]
        private string _body;
        private string _displayString;
        private string _recipients;
        private string _subject;
        private string _sender;
        private DateTimeOffset? _received;
        private MailOperations _mailOperations = new MailOperations();

        public string DisplayString
        {
            get
            {
                return _displayString;
            }
            set
            {
                SetProperty(ref _displayString, value);
            }
        }

        public string ID
        {
            set
            {
                _id = value;
            }

            get
            {
                return _id;
            }
        }

        //Specfies the mail body as a text block consisting of multiple lines. This prevents body display
        //as a single line of text.
        [DataType(DataType.MultilineText)]
        public string Body 
        {
            get
            {
                return _body;
            }

            set
            {
                SetProperty(ref _body, value);
            }
        }
        public string Recipients 
        {
            get
            {
                return _recipients;
            }

            set
            {
                SetProperty(ref _recipients, value);
            }
        }
        public string Subject 
        {
            get
            {
                return _subject;
            }

            set
            {
                SetProperty(ref _subject, value);
            }
        }
        public string Sender 
        {
            get
            {
                return _sender;
            }

            set
            {
                SetProperty(ref _sender, value);
            }       
        }

        //Display format for the date and time of message receipt. The DataFormatString defines the display
        //of the DateTimeOffset object when it is bound to a XAML control.
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy HH:mm tt}")]
        public DateTimeOffset? Received 
        {
            get
            {
                return _received;
            }

            set
            {
                SetProperty(ref _received, value);
            } 
        }

        public MailItemViewModel()
        {
            this._id = string.Empty;
            this._body = "New mail";
            this._subject = string.Empty;
            this._recipients = string.Empty;
            this._sender = string.Empty;
            this._received = null;
            this._displayString = string.Empty;

        }

        public MailItemViewModel(IMessage serverMailItem)
        {
            initialize(serverMailItem);
        }

        private void initialize(IMessage serverMailItem)
        {

            _id = serverMailItem.Id;

            //If HTML, take text. Otherwise, use content as is
            string bodyContent = serverMailItem.Body.Content;
            if (serverMailItem.Body.ContentType == BodyType.HTML)
            {
                bodyContent = HtmlUtilities.ConvertToText(bodyContent);
            }
            _body = bodyContent;

            _subject = serverMailItem.Subject;

            _recipients = _mailOperations.BuildRecipientList(serverMailItem.ToRecipients);

            if (serverMailItem.Sender != null)
            {
                _sender = serverMailItem.Sender.EmailAddress.Address;
            }
            else
                _sender = string.Empty; // Sometimes, mails exist as draft, and therefore haven't been sent.

            if (serverMailItem.DateTimeReceived != null)
            {
                _received = serverMailItem.DateTimeReceived;
            }

            _displayString = _received + ": " +_sender + ":: " + _subject;
        }


    }

}
