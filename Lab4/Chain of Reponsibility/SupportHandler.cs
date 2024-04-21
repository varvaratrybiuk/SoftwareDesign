using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility
{
    public class SupportHandler : IHandler
    {
        private IHandler? _next;

        public IHandler SetNextHandler(IHandler next)
        {
            this._next = next;
            return next;
        }
        public virtual void Handle(int num)
        {
            if(_next != null)
            {
                _next.Handle(num);
            }
            else
            {
                throw new Exception("Invalid choice. Please try again.");
            }
        }
    }
}
