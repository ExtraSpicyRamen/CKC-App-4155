using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKC_App_4155.objects
{
    public class Message : ObservableObject
    {
        public int senderID, messageID, receiverID = 0;
        public string mTitle, mContent, senderName, receiverName = "";
        public string MTitle
        {
            get
            {
                return this.mTitle;
            }
            set
            {
                SetProperty(ref mTitle, value);

            }
        }
        public string SenderName
        {
            get
            {
                return this.senderName;
            }
            set
            {
                SetProperty(ref senderName, value);

            }
        }
        public string ReceiverName
        {
            get
            {
                return this.receiverName;
            }
            set
            {
                SetProperty(ref receiverName, value);

            }
        }
        public Message(){ }

        public Message(int senderID, int messageID, int receiverID, string mTitle, string mContent, string senderName, string receiverName)
        {
            this.senderID = senderID;
            this.messageID = messageID;
            this.receiverID = receiverID;
            this.mContent = mContent;
            this.mTitle = mTitle;
            this.senderName = senderName;
            this.receiverName = receiverName;
        }
        public int GetSenderID()
        {
            return this.senderID;
        }
        public int GetMessageID() 
        { 
            return this.messageID;
        }
        public int GetReceiverID()
        {
            return this.receiverID;
        }
        public string GetmTitle()
        {
            return this.mTitle;
        }
        public string GetmContent()
        {
            return this.mContent;
        }
        public string GetSenderName()
        {
            return this.senderName;
        }
        public string GetReceiverName()
        {
            return this.receiverName;
        }
        public void SetSenderID(int senderID)
        {
            this.senderID = senderID;
        }
        public void SetMessageID(int messageID)
        {
            this.messageID = messageID;
        }
        public void SetReceiverID(int receiverID)
        {
            this.receiverID = receiverID;
        }
        public void SetmTitle(string mtitle)
        {
            this.mTitle = mtitle;
        }
        public void SetmContent(string mcontent)
        {
            this.mContent = mcontent;
        }
        public void SetSenderName (string senderName)
        {
            this.senderName = senderName;
        }
        public void SetReceiverName (string receiverName)
        {
            this.receiverName = receiverName;
        }
    }
}
