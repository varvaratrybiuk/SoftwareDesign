using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class Director
    {
        private IBuilder _builder;
        public Director SetBuilder(IBuilder builder)
        {
            this._builder = builder;
            return this;
        }

        public Director(IBuilder builder)
        {
            
            this._builder = builder;
        }
        public Character WizardCat()
        {
            return _builder.SetName("Tom")
                .SetAppearance("Tall, muscular")
                .AddClothes("Wizard Hat")
                .AddClothes("Cloak")
                .AddToInventory("Magic Wand")
                .AddToInventory("Spell Book")
                .SetGood()
                .GetCharacter();
        }
        public Character WizardFrog()
        {
            return _builder.SetName("Tony")
                .SetAppearance("Tall, muscular")
                .AddClothes("Black wizard Hat")
                .AddClothes("Darck green cloak")
                .AddToInventory("Magic Wand")
                .AddToInventory("Spell Book")
                .AddToInventory("Potion")
                .SetGood()
                .GetCharacter();
        }
    }
}
