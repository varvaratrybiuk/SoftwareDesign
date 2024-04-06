using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    public class Mage : Hero
    {
        public Mage() : base()
        {
            Armoredness = 50;
            Attack = 100;
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
