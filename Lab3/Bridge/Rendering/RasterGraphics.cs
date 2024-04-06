using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Rendering
{
    public class RasterGraphics : IRenderer
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing Circle as pixels");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing Square as pixels");
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Drawing Triangle as pixels");
        }
    }
}
