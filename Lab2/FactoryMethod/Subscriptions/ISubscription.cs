using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Subscriptions
{
    public interface ISubscription
    {
        double MonthlyFee { get; }
        int MinimumSubscriptionPeriod { get; }
        List<string> Channels { get; }
        string GetInfo();
    }
}
