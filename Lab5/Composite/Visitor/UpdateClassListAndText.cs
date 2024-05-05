﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Visitor
{
    public class UpdateClassListAndText : IVisitor
    {
        public void Visit(LightElementNode visitor)
        {
            visitor.CssClasses.Insert(0, visitor.TagName);
        }

        public void Visit(LightTextNode visitor)
        {
            visitor.UpdateText(".");
        }
    }
}
