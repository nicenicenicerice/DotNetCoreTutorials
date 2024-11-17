using LangConsoleApp.Graphs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LangConsoleApp
{
    internal class Program07
    {
        public static void Run()
        {
            Console.WriteLine("C# - Data Types - Struct");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-struct");
            Console.WriteLine("----------------------------------------");

            Coordinate2d coord2d01 = new Coordinate2d();
            PrintCoordinate2dInfo("coord2d01", coord2d01);

            Coordinate2d coord2d02 = new Coordinate2d(1, 3);
            PrintCoordinate2dInfo("coord2d02", coord2d02);

            Coordinate2d coord2d03;
            coord2d03.X = 2;
            coord2d03.Y = 4;
            PrintCoordinate2dInfo("coord2d03", coord2d03);

            Coordinate2d coord2d04 = new Coordinate2d();
            coord2d04.SetOrigin();
            PrintCoordinate2dInfo("coord2d04", coord2d04);

            Coordinate2d coord2d05 = Coordinate2d.Create(5, 7);
            PrintCoordinate2dInfo("coord2d05", coord2d05);
            Console.WriteLine("----------------------------------------");

            Coordinate3d coord3d01 = new Coordinate3d();
            PrintCoordinate3dInfo("coord3d01", coord3d01);
            Console.WriteLine("----------------------------------------");

            Coordinate3d coord3d02_a = new Coordinate3d(1, 1, 1);
            Coordinate3d coord3d02_b = coord3d02_a;
            PrintCoordinate3dInfo("coord3d02_a_before", coord3d02_a, false);
            PrintCoordinate3dInfo("coord3d02_b_before", coord3d02_b, false);
            Console.WriteLine(">> set coord3d02_b.X = 2");
            Console.WriteLine(">> set coord3d02_b.Y = 2");
            Console.WriteLine(">> set coord3d02_b.Z = 2");
            coord3d02_b.X = 2;
            coord3d02_b.Y = 2;
            coord3d02_b.Z = 2;
            PrintCoordinate3dInfo("coord3d02_a_after ", coord3d02_a, false);
            PrintCoordinate3dInfo("coord3d02_b_after ", coord3d02_b, false);
        }

        private static void PrintCoordinate2dInfo(string name, Coordinate2d coord, bool isNewLine = true)
        {
            Console.WriteLine($"{name}: X = {coord.X}；Y = {coord.Y}");
            if (isNewLine)
            {
                Console.WriteLine();
            }
        }

        private static void PrintCoordinate3dInfo(string name, Coordinate3d coord, bool isNewLine = true)
        {
            Console.WriteLine($"{name}: X = {coord.X}；Y = {coord.Y}；Z = {coord.Z}");
            if (isNewLine)
            {
                Console.WriteLine();
            }
        }
    }
}
