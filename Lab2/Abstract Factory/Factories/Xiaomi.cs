using Abstract_Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public class Xiaomi : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new XiaomiBook("Intel Core i5", "1920x1080", true);
        }

        public INotebook CreateNotebook()
        {
            return new XiaomiNotebook("15.6 inches", "Intel Core i7", true);
        }

        public ISmartphone CreateSmartphone()
        {
            return new Xiaomi14("AMOLED", 5000, "64 MP");
        }

        public IEbook Ebook()
        {
            return new XiaomiEbook("E Ink", true, 16);
        }
    }
}
