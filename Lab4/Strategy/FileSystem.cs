using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileSystem : ILoadType
    {
        public void Load(string path)
        {
            Console.WriteLine($"Loading image from file system: {path}");
        }
    }
}
