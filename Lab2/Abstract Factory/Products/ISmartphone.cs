using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public interface ISmartphone 
    {
        string ScreenType { get; set; }
        int BatteryCapacity { get; set; }
        string CameraResolution { get; set; }
    }
}
