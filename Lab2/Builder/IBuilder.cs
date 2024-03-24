using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        IBuilder SetName(string name);
        IBuilder SetAppearance(string appearance);
        IBuilder AddClothes(string clothes);
        IBuilder AddToInventory(string item);
        IBuilder SetGood();
        Character GetCharacter();
    }
}
