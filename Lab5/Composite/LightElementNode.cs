using Composite.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    public class LightElementNode : ILightNode, IType
    {
        private List<ILightNode> _children = new List<ILightNode>();
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CssClasses { get; }
       

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
        }
        public void AddChild(ILightNode node)
        {
            _children.Add(node);
        }
        public void RemoveChild(ILightNode node) { 
            _children.Remove(node);
        }
        public void innerHTML()
        {
            foreach (var node in _children) 
                node.outerHTML();
        }

        public void outerHTML()
        {
            Console.WriteLine($"<{TagName} class=\"{string.Join(" ", CssClasses)}\">");
            innerHTML();
            if (DisplayType == "block")
            {
                Console.WriteLine($"</{TagName}{(ClosingType == "closed" ? ">" : " />")}");
            }
        }
        public List<ILightNode> GetChildren()
        {
            return _children;
        }
        public IIterator GetDepthIterator()
        {
            return new DepthIterator(this);
        }

        public IIterator GetBreadIterator()
        {
            return new BreadthIterator(this);
        }
    }
}
