using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReader : ISmartTextReader
    {
       
        public char[][] ReadText(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            char[][] textArray = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                textArray[i] = lines[i].ToCharArray();
            }
            return textArray;
        }
    }
}
