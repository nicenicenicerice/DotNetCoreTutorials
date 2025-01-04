using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.Utils
{
    public struct Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Size { get; set; } = 1;

        public Point(int x, int y, int size = 1)
        {
            X = x;
            Y = y;
            Size = size;
        }
    }

    public class Painter
    {
        public Point DrawPoint(int x, int y)
        {
            return new Point(x, y);
        }

        public Point DrawPoint(int x, int y, int size)
        {
            return new Point(x, y, size);
        }
    }
}
