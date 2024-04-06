using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    public class Palladin : Hero
    {
        public Palladin()
        {

            Armoredness = 100;
            Attack = 1200;
        }

        public override float GetArmoredness()
        {
            return Armoredness;
        }

        public override float GetStrength()
        {
            return Attack;
        }
    }
}
