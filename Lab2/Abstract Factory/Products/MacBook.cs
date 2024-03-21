using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public class MacBook : ILaptop
    {
        public string GraphicsCard { get; set; }
        public string DisplayResolution { get; set; }
        public bool SSD { get; set; }
        public MacBook(string graphicsCard, string displayResolution, bool sSD)
        {
            GraphicsCard = graphicsCard;
            DisplayResolution = displayResolution;
            SSD = sSD;
        }
    }
}
