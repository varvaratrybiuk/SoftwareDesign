﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer { 
    public class LightTextNode : ILightNode
    {
        protected string text;
        public LightTextNode(string text) {
            this.text = text;
        }
        public void innerHTML()
        {
            Console.WriteLine(text);
        }

        public void outerHTML()
        {
            Console.WriteLine(text);
        }
    }
}
