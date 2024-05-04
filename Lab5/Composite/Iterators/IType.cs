using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public interface IType
    {
        public IIterator GetDepthIterator();
        public IIterator GetBreadIterator();
    }
}
