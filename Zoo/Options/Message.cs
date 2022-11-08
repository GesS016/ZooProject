using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Zoo.Options
{
    public class Message
    {
        public string Text { get; set; }
        public string SenderType { get; set; }
        public string SenderName { get; set; }
        public MessageType MessageType { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Message message &&
                   Text == message.Text &&
                   SenderType == message.SenderType &&
                   SenderName == message.SenderName &&
                   MessageType == message.MessageType;
        }

        public override string ToString()
        {
            return $"{SenderType} {SenderName}: {MessageType} {Text}";
        }
    }
}
