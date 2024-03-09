using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.MoneyFolder
{
    public class MoneyUAH : Money
    {
        public MoneyUAH() { }

        public MoneyUAH(int Bill, float Penny) : base(Bill, Penny)
        {
        }

        public override string show()
        {
            return base.show() + "UAH";
        }

    }
}
