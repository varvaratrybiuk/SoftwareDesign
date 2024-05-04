using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AddCssClass : ICommand
    {
        private LightElementNode _node;
        private string _cssClass;

        public AddCssClass(LightElementNode node, string cssClass)
        {
            _node = node;
            _cssClass = cssClass;
        }

        public void Execute()
        {
            _node.CssClasses.Add(_cssClass);
        }

        public void Undo()
        {
            _node.CssClasses.Remove(_cssClass);
        }
    }
}
