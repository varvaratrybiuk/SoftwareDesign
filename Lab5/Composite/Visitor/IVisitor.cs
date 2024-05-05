using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Visitor
{
    public interface IVisitor
    {
        public void Visit(LightElementNode visitor);
        public void Visit(LightTextNode visitor);
    }
}
