using Observer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Observer
{
    public class LightElementNode : ILightNode
    {
        private List<ILightNode> _children = new List<ILightNode>();

        private List<IEventListener> _subscribers = new List<IEventListener>();
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

        public void Subscribe(IEventListener subscriber)
        {
            this._subscribers.Add(subscriber);
        }
        public void Unsubscribe(IEventListener subscriber)
        {
            this._subscribers.Remove(subscriber);
        }
        protected void _notify()
        {
            _subscribers.ForEach(sub => sub.HandleEvent());
        }
        public void InvokeEvents()
        {
            _notify();
        }
    }
}
