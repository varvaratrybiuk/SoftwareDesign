using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public interface INotebook 
    {
        string ScreenSize { get; set; }
        string ProcessorType { get; set; }
        bool Touchscreen { get; set; }
    }
}
