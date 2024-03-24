using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CharacterBuilder
    {
        protected Character _character = new Character();
        protected void _reset()
        {
            this._character = new Character();
        }

        public Character GetCharacter()
        {
            Character character = this._character;
            this._reset();
            return character;
        }
    }
       
    
}
