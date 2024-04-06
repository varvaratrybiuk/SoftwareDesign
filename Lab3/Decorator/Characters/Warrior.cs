using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    public class Warrior : Hero
    {
        public Warrior()
        {

            Armoredness = 150;
            Attack = 150;
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
