using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility.Levels
{
    public class Level1SupportHandler : SupportHandler
    {
        public override void Handle(int num)
        {
            if(num == 1)
            {
                Console.WriteLine("Your issue will be resolved shortly.(Question 1)");
                return;
            } 
            base.Handle(num);
        }
    }
}
