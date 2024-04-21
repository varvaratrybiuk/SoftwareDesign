using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
   public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<AirCraft> _aircrafts = new List<AirCraft>();

        public CommandCentre(Runway[] runways, AirCraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }
        public void CanLand(int AirCraftIndex)
        {
            var freeRunway = _runways.FirstOrDefault(runway => runway.IsBusyWithAircraft == false);
            if (freeRunway != null)
            {
                _aircrafts[AirCraftIndex].Land();
                _aircrafts[AirCraftIndex].CurrentRunway = freeRunway.Id;
                freeRunway.IsBusyWithAircraft = true;
                _aircrafts[AirCraftIndex].IsTakingOff = false;
                Console.WriteLine($"Aircraft {_aircrafts[AirCraftIndex].Name} has landed.");
                freeRunway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"Could not land, the runway is busy.");
            }
        }

        public void AirCraftTakeOff(int AirCraftIndex)
        {
            var runway = _runways.FirstOrDefault(runway => runway.Id == _aircrafts[AirCraftIndex].CurrentRunway);
            if (runway != null)
            {
                _aircrafts[AirCraftIndex].TakeOff();
                _aircrafts[AirCraftIndex].IsTakingOff = true;
                _aircrafts[AirCraftIndex].CurrentRunway = null;
                runway.IsBusyWithAircraft = false;
                Console.WriteLine($"Aircraft {_aircrafts[AirCraftIndex].Name} has took off.");
                runway.HighLightGreen();
            }
        }

        public bool CheckIsActiveRunway(int RunwayIndex) => _runways[RunwayIndex].IsBusyWithAircraft && _aircrafts.Any(aircraft => aircraft.CurrentRunway == _runways[RunwayIndex].Id && !aircraft.IsTakingOff);
          
      
    }
}
