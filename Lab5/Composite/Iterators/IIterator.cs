using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public interface IIterator
    {
        public object? Next();
        public object? Current();
        public bool IsDone();
        public void Reset();
    }
}
