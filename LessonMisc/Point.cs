namespace Breno
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}


// Point p; 
// p.X = 20;
// p.Y = 30;
// Console.WriteLine(p.ToString());
// Point p2 = new Point();
// Console.WriteLine(p2);