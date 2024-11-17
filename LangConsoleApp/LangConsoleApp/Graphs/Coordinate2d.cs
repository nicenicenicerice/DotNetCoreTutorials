namespace LangConsoleApp.Graphs
{
    internal struct Coordinate2d
    {
        public int X;
        public int Y;

        public Coordinate2d()
        {
            Console.WriteLine($"Coordinate2d constructor() is being called.");
        }

        public Coordinate2d(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Coordinate2d constructor(X: {X}, Y: {Y}) is being called.");
        }

        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }

        public static Coordinate2d Create(int x, int y)
        {
            return new Coordinate2d(x, y);
        }
    }
}
