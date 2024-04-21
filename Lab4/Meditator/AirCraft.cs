using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
    public class AirCraft
    {
        public string Name;
        public Guid? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; } = true;
        public AirCraft(string name, int size)
        {
            this.Name = name;
        }
        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
          
        
        }
        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
        }
    }
}
