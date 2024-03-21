using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products
{
    public class IPhone15 : ISmartphone
    {
        public string ScreenType { get; set; }
        public int BatteryCapacity { get; set; }
        public string CameraResolution { get; set; }
        public IPhone15(string ScreenType, int BatteryCapacity, string CameraResolution)
        {
            this.ScreenType = ScreenType;
            this.BatteryCapacity = BatteryCapacity;
            this.CameraResolution = CameraResolution;
        }
    }
}
