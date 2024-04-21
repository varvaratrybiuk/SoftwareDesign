using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Events
{
    public class Click : IEventListener
    {
        public void HandleEvent()
        {
            Console.WriteLine("Click");
        }
    }
}
