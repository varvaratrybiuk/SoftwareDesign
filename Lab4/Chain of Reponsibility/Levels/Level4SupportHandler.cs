using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility.Levels
{
    public class Level4SupportHandler : SupportHandler
    {
        public override void Handle(int num)
        {
            if (num == 4)
            {
                Console.WriteLine("Your issue is being addressed by our top experts.(Question 4)");
                return;
            }
            base.Handle(num);

        }
    }
}
