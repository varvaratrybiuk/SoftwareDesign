using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public class GalaxyEbook : IEbook
    {
        public string EReaderType { get; set; }
        public bool Backlight { get; set; }
        public int StorageCapacity { get; set; }
        public GalaxyEbook(string EReaderType, bool Blacklight, int StorageCapacity) { 
            this.EReaderType = EReaderType;
            this.Backlight = Blacklight;
            this.StorageCapacity = StorageCapacity;
        }
    }
}
