using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public class WebSite : CreateSubscription
    {
        public override ISubscription BuySubcription(string nameofsub)
        {
            Console.WriteLine("Client buys subscription using WebSite:");
            return ReturnSubscription(nameofsub);
        }
    }
}
