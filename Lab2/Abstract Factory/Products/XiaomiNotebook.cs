using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public class XiaomiNotebook : INotebook
    {
        public string ScreenSize { get; set; }
        public string ProcessorType { get; set; }
        public bool Touchscreen { get; set; }
        public XiaomiNotebook(string ScreenSize, string ProcessorType, bool TouchScreen)
        {
            this.ScreenSize = ScreenSize;
            this.ProcessorType = ProcessorType;
            Touchscreen = TouchScreen;
        }
    }
}

