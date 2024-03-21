using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
   public interface ILaptop 
    {
        string GraphicsCard { get; set; }
        string DisplayResolution { get; set; }
        bool SSD { get; set; }
    }
}
