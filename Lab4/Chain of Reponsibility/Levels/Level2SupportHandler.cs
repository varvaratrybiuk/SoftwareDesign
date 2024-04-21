using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility.Levels
{
    public class Level2SupportHandler : SupportHandler
    {
        public override void Handle(int num)
        {
            if (num == 2)
            {
                Console.WriteLine("Your issue has been escalated.(Question 2)");
                return;
            }
            base.Handle(num);
        }
    }
}
