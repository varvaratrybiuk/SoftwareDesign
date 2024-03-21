using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public double MonthlyFee { get; } = 5.45;

        public int MinimumSubscriptionPeriod { get;  } = 2;

        public List<string> Channels { get; } = new List<string> { "Serials", "MusicChannel", "LearnLanguages"};

        public string GetInfo()
        {
            
        }
    }
}
