using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flyweight
{
    public class LightElementNodeUpdated : ILightNode
    {
        private List<ILightNode> _children = new List<ILightNode>();
        private Tag tag;
        public List<string> CssClasses { get; }
      
        public LightElementNodeUpdated(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            CssClasses = cssClasses;
            tag = TagFactory.getTag(tagName, displayType, closingType);
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
            Console.WriteLine($"<{tag.TagName} class=\"{string.Join(" ", CssClasses)}\">");
            innerHTML();
            if (tag.DisplayType == "block")
            {
                Console.WriteLine($"</{tag.TagName}{(tag.ClosingType == "closed" ? ">" : " />")}");
            }
        }
    }
}
