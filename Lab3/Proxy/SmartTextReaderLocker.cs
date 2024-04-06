﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
   public class SmartTextReaderLocker : ISmartTextReader
    {

        private SmartTextReader _reader;
        private Regex _regex;

        public SmartTextReaderLocker(SmartTextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern);
        }
        
        public char[][]? ReadText(string filepath)
        {
            if (!_regex.IsMatch(filepath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return _reader.ReadText(filepath);
        }
    }
}
