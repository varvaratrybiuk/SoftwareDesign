using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public double MonthlyFee { get; } = 20.45;

        public int MinimumSubscriptionPeriod { get;  } = 1;

        public List<string> Channels { get; } = new List<string> { "Premium Movies", "Exclusive Shows", "Live Events" };

        public void GetInfo()
        {
            Console.WriteLine($"About Premium:\n{MonthlyFee} USD\n {MinimumSubscriptionPeriod} month");       
        }
    }
}
