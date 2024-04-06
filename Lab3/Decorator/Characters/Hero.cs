using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    public abstract class Hero
    {
        public float Attack { get; set; }
        public float Armoredness { get; set; }
        public abstract float GetStrength();

        public abstract float GetArmoredness();



    }
}
