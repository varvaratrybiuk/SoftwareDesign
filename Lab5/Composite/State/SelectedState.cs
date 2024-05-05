using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.State
{
    public class SelectedState : INodeElementState
    {
        protected LightElementNode _node;
        
        public SelectedState(LightElementNode node) {  _node = node; }
        public void MouseOut()
        {
            Console.WriteLine($"The cursor goes beyond the node '{_node.TagName}'.");
            _node.ChangeState(new UnselectedState(_node));
        }

        public void MouseOver()
        {
            Console.WriteLine($"The cursor is on the node '{_node.TagName}'.");
        }
    }
}
