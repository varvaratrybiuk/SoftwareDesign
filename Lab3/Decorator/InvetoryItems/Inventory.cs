using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Characters;

namespace Decorator.InvetoryItems
{
    public abstract class Inventory : Hero
    {

        protected Hero _hero;
        public Inventory(Hero hero) : base()
        {
            _hero = hero;
        }

    }
}
