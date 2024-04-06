using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextChecker : ISmartTextReader
    {
        private SmartTextReader _reader {  get; set; }
      
        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }
        private void LineAndCharCounter(char[][] text)
        {
            int LineCount = 0, CharCount = 0;
            foreach (var line in text)
            {
                LineCount++;
                foreach (var c in line)
                {
                    CharCount++;
                }
            }
            Console.WriteLine($"Lines: {LineCount}. Chars: {CharCount}.");
        }
        public char[][]? ReadText(string filepath)
        {
            try
            {
                Console.WriteLine("Trying to open a file...");
                var text = _reader.ReadText(filepath);
                Console.WriteLine("Reading was successful!");
                Console.WriteLine("Closing file...");
                LineAndCharCounter(text);
                return text;

            }
            catch(Exception e) {
                Console.WriteLine($"Error: {e.Message}");
                return null;

            }
        }
    }
}
