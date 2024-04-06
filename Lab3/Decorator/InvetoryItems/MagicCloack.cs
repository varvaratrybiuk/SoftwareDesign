using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Characters;

namespace Decorator.InvetoryItems
{
    public class MagicCloack : Inventory
    {
        public MagicCloack(Hero hero) : base(hero)
        {
        }
        public override float GetArmoredness()
        {
            return _hero.GetArmoredness() + 100;
        }

        public override float GetStrength()
        {
            return _hero.GetStrength() + 50;
        }
    }
}
