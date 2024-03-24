namespace Builder
{
    public class HeroBuilder : CharacterBuilder, IBuilder
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

        public IBuilder AddClothes(string clothes)
        {
            _character.Clothes.Add(clothes);
            return this;
        }

        public IBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public IBuilder SetGood()
        {
            _character.Good = true;
            return this;
        }

       
    }
}
