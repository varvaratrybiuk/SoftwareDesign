using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.State
{
    public class UnselectedState : INodeElementState
    {
        protected LightElementNode _node;
        public UnselectedState(LightElementNode node)
        {
            _node = node;
        }

        public void MouseOut()
        {
            Console.WriteLine($"The cursor is already outside the node '{_node.TagName}'.");
           
            
        }

        public void MouseOver()
        {
            Console.WriteLine($"The cursor is directed to the node '{_node.TagName}'.");
            _node.ChangeState(new SelectedState(_node));
        }
    }
}
