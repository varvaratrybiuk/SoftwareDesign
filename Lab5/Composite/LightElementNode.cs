using Composite.Iterators;
using Composite.State;
using Composite.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    public class LightElementNode : LifecycleHooks, ILightNode, IType, INodeElementState
    {
        private List<ILightNode> _children = new List<ILightNode>();
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CssClasses { get; }
        public INodeElementState State { get; private set; }
       

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            State = new UnselectedState(this);
            CreateMethod();
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
            foreach (var node in _children) {
                node.outerHTML();
                if (node is LightTextNode)
                    TextMethod();
            }
               
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
        public void ChangeState(INodeElementState state) => State = state;

        public void MouseOver() => State.MouseOver();

        public void MouseOut() => State.MouseOut();

        public override void OnCreate()
        {
            Console.WriteLine("Node was created");
        }

        public override void OnInserted()
        {
            Console.WriteLine("Node was inserted");
        }
         public override void OnTextRendered()
        {
            Console.WriteLine($"Text  was rendered");
        }
      
    }
}
