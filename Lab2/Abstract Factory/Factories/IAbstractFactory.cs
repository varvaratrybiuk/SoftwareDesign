using Abstract_Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public interface IAbstractFactory
    {
        public ISmartphone CreateSmartphone();
        public ILaptop CreateLaptop();
        public INotebook CreateNotebook();
        public IEbook Ebook();
    }
}
