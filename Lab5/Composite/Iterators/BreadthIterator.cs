using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public class BreadthIterator : IIterator
    {
        private List<ILightNode> list = new List<ILightNode>();
        private int _cursor = -1;

        public BreadthIterator(ILightNode root)
        {
            BFS(root);
        }

        private void BFS(ILightNode node)
        {
            Queue<ILightNode> queue = new Queue<ILightNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                list.Add(current);

                if (current is LightElementNode)
                {
                    var children = ((LightElementNode)current).GetChildren();
                    foreach (var child in children)
                    {
                        queue.Enqueue(child);
                    }
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


