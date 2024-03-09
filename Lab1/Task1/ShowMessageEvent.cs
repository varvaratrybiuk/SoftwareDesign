using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ShowMessageEvent : EventArgs 
    {
        public string Message { get; set; }
        public ShowMessageEvent()
        {
            Message = string.Empty;
        }
        public ShowMessageEvent(string Message) {
            this.Message = Message;
        }
    }
}
