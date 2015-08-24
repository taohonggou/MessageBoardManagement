using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Model
{
    public class MessageInfo
    {
        //MessageId  MasterUserId  GuestUserId  MessageContent  MessageTime  MessageDelFlag
        int messageId;

        public int MessageId
        {
            get { return messageId; }
            set { messageId = value; }
        }
        int masterUserId;

        public int MasterUserId
        {
            get { return masterUserId; }
            set { masterUserId = value; }
        }
        int guestUserId;

        public int GuestUserId
        {
            get { return guestUserId; }
            set { guestUserId = value; }
        }
        string messageContent;

        public string MessageContent
        {
            get { return messageContent; }
            set { messageContent = value; }
        }
        DateTime messageTime;

        public DateTime MessageTime
        {
            get { return messageTime; }
            set { messageTime = value; }
        }
        int messageDelFlag;

        public int MessageDelFlag
        {
            get { return messageDelFlag; }
            set { messageDelFlag = value; }
        }
    }
}
