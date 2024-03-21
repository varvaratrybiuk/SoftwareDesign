using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public class ManagerCall : CreateSubscription
    {
        public override ISubscription BuySubcription(string nameofsub)
        {
            Console.WriteLine("Client buys subscription with the help of manager:");
            return ReturnSubscription(nameofsub);
        }
    }
}
