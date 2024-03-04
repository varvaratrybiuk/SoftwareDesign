using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1.MoneyFolder
{
    public class Money
    {
        public int Bill { get; set; }
        public float Penny { get; set; }

        public Money() { }
        public Money(int Bill, float Penny) { 
            this.Bill = Bill;
            this.Penny = Penny;
        }
        private float return_float()
        {
            while (Penny > 1)
            {
                Penny /= 10;
            }
            return Bill + Penny;
        }
        public float show()
        {
            return return_float();
        }
        public static Money operator +(Money money1, float value)
        {
            int totalBills = money1.Bill + (int)value;
            float totalPennys = money1.Penny + (value - (int)value);

            if (totalPennys >= 1)
            {
                totalBills++;
                totalPennys -= 1;
            }

            return new Money(totalBills, totalPennys);
        }

        public static Money operator -(Money money1, float value)
        {
            int totalBills = money1.Bill - (int)value;

            if (totalBills < 0)
            {
                return new Money(0, 0);
            }

            float totalPennys = money1.Penny - (value - (int)value);

            if (totalPennys < 0)
            {
                totalBills--;
                totalPennys += 1;
            }

            return new Money(totalBills, totalPennys);
        }

    }
}
