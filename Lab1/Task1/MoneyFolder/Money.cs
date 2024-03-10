using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1.MoneyFolder
{
    public abstract class Money
    {
        public int Bill { get; set; }
        public float Penny { get; set; }


       public Money() { }
        public Money(int Bill, float Penny) { 
            this.Bill = Bill;
            this.Penny = Penny;
        }
       public void set_amount(int Bill, float Penny)
        {
            this.Bill = Bill;
            this.Penny = Penny;
        }
        public virtual string show()
        {
            return $"{Bill}.{Penny}";
        }
        public void  Add(float value)
        {
            Bill = Bill + (int)value;
            Penny = Penny + (value - (int)value);

            if (Penny >= 1)
            {
                Bill++;
                Penny -= 1;
            }

            
        }

        public void Subtract(float value)
        {
            Bill -= (int)value;

            if (Bill < 0)
            {
                Bill = 0;
                Penny = 0;
            }

            Penny = Penny - (value - (int)value);

            if (Penny < 0)
            {
                Bill--;
                Penny += 1;
            }

           
        }

    }
}
