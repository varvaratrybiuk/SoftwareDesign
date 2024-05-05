using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Template_Method
{
    public abstract class LifecycleHooks
    {
        public void CreateMethod()
        {
            OnCreate();
            OnInserted();
        }
        public void TextMethod()
        {
            OnTextRendered();
        }
        public virtual void OnCreate() { }
        public virtual void OnInserted() { }
        public virtual void OnTextRendered() { }
    }
}
