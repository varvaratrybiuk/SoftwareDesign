using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Events
{
    public class Mouseover : IEventListener
    {
        public void HandleEvent()
        {
            Console.WriteLine("Mouseover");
        }
    }
}
