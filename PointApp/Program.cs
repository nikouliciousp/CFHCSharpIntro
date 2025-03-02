namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = Point.GetPoint();
            p.Move10();
            Console.WriteLine(p.ToString());

            Console.WriteLine();
            Point2D p2 = Point2D.GetPoint2D();
            p2.Move10();
            p2.Move10();
            Console.WriteLine(p2.ToString());

        }
    }
}
