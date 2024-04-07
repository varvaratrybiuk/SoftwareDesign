using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public  class Tag
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public Tag (string tagName, string displayType, string closingtype)
        {
            this.TagName = tagName;
            this.DisplayType = displayType;
            this.ClosingType = closingtype;
        }
    }
}
