using Abstract_Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class IPhone : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new MacBook("Apple M1", "2560x1600", true);
        }

        public INotebook CreateNotebook()
        {
            return new IPhoneNotebook("11.94x5.99", "Apple A14 Bionic", true);
        }

        public ISmartphone CreateSmartphone()
        {
            return new IPhone15("Super Retina XDR OLED", 3687, "12 MP");
        }

        public IEbook Ebook()
        {
            return new IPhoneEbook("E Ink", true, 8);
        }
    }
}
