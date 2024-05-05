using Composite.Template_Method;
using Composite.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightTextNode :LifecycleHooks, ILightNode
    {
        protected string text;
        public LightTextNode(string text) {
            this.text = text;
        
        }
        public void UpdateText(string text)
        {
            this.text += text;
        } 
        public void innerHTML()
        {
            Console.WriteLine(text);
        }

       

        public void outerHTML()
        {
            Console.WriteLine(text);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
