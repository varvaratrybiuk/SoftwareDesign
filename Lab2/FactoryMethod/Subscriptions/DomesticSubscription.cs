using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public double MonthlyFee { get; } = 15.45;

        public int MinimumSubscriptionPeriod { get; } = 1;

        public List<string> Channels { get;  } = new List<string> { "Local News", "Entertainment", "Sports" };

        public void GetInfo()
        {
            Console.WriteLine($"About Domestic:\n{MonthlyFee} USD\n {MinimumSubscriptionPeriod} month");
        }
    }
}
