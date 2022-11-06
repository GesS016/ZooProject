using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
     public class Message
    {
        public string Text { get; set; }
        public string SenderType { get; set; }
        public string SenderName { get; set; }
        public MessageType MessageType { get; set; }
    }
}
