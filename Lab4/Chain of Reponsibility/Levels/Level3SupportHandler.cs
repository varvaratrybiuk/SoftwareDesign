using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility.Levels
{
    public class Level3SupportHandler : SupportHandler
    {
        public override void Handle(int num)
        {
            if (num == 3)
            {
                Console.WriteLine("A specialist will contact you soon.(Question 3)");
                return;
            }
            base.Handle(num);

        }
    }
}
