using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : CharacterBuilder, IBuilder
    {
        public IBuilder AddToInventory(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public IBuilder SetAppearance(string appearance)
        {
            _character.Appearance = appearance;
            return this;
        }

        public IBuilder SetClothes(string clothes)
        {
            _character.Clothes = clothes;
            return this;
        }

        public IBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public IBuilder SetGood()
        {
            _character.Good = false;
            return this;
        }
        
    }
}
