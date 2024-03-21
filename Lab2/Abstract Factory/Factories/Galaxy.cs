using Abstract_Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class Galaxy : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new GalaxyBook("NVIDIA GeForce GTX 1650","1920x1080",true);
        }

        public INotebook CreateNotebook()
        {
            return new GalaxyNotebook("13.1x8.2", "NVIDIA GeForce GTX 1650", true);
        }

        public ISmartphone CreateSmartphone()
        {
            return new GalaxyA55("Super AMOLED", 4500,"48 MP");
        }

        public IEbook Ebook()
        {
            return new GalaxyEbook("E Ink", true,8);
        }
    }
}
