using System;

namespace Chat
{
    class MessageInfo
    {
        public MessageInfo(Int32 id,Int32 idFrom,Int32 idTo,String message,DateTime sentDate)
        {
            this.Id = id;
            this.IdFrom = idFrom;
            this.IdTo = idTo;
            this.Message = message;
            this.SentDate = sentDate;
        }

        public Int32 Id { get; set; }
        public Int32 IdFrom { get; set; }
        public Int32 IdTo { get; set; }
        public String Message { get; set; }
        public DateTime SentDate { get; set; }
    }
}