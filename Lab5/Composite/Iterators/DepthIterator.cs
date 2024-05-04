using System;
using Composite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace Composite.Iterators
{
    public class DepthIterator : IIterator
    {
        private List<ILightNode> list = new List<ILightNode>();
        private int _cursor = -1;

        public DepthIterator(ILightNode root)
        {
            DFS(root);
        }

        private void DFS(ILightNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node);
            if (node is LightElementNode)
            {
                var children = ((LightElementNode)node).GetChildren();
                foreach (var child in children)
                {
                    DFS(child);
                }
            }
        }

        public object? Current()
        {
            return _cursor >= 0 && _cursor < list.Count ? list[_cursor] : null;
        }

        public bool IsDone()
        {
            return _cursor == list.Count - 1;
        }

        public object? Next()
        {
            if (IsDone())
            {
                return null;
            }
            _cursor++;
            return Current();
        }

        public void Reset()
        {
            _cursor = -1;
            list.Clear();
        }
    }

}
       
