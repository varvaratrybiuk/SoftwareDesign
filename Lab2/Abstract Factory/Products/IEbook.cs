using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public interface IEbook 
    {
        string EReaderType { get; set; }
        bool Backlight { get; set; }
        int StorageCapacity { get; set; }
    }
}
