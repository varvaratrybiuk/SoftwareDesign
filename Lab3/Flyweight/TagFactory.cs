using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public static class TagFactory
    {
        private static Dictionary<string, Tag> Tags = new Dictionary<string, Tag>();
        public static Tag getTag(string name, string displayType, string closingtype)
        {
            var tag = Tags.GetValueOrDefault(name);
            if(tag == null)
            {
                tag = new Tag(name, displayType, closingtype);
                Tags.Add(name, tag);
            }
            return tag;
        }
    }
}
