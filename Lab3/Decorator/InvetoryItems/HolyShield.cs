using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Characters;

namespace Decorator.InvetoryItems
{
    public class HolyShield : Inventory
    {
        public HolyShield(Hero hero) : base(hero)
        {


        }

        public override float GetArmoredness()
        {
            return _hero.GetArmoredness() + 300;
        }

        public override float GetStrength()
        {
            return _hero.GetStrength() + 0;
        }
    }
}
