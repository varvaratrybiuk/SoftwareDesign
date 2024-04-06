using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        public string filepath {  get; private set; }

        public FileWriter(string filepath)
        {
            this.filepath = filepath;
        }

        public virtual void Write(string message)
        {
            Console.WriteLine($"Write a '{message}' into a {filepath} without a new line character");
        }
        public virtual void WriteLine(string message)
        {
            Console.WriteLine($"Write a '{message}' into a {filepath} with a new line character");
        }
    }
}
