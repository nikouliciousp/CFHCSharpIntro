namespace PointInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Point
            Point point = Point.GetPoint();

            // Move the point by 5 units
            point.Move5();

            // Print the point
            Console.WriteLine(point);

            // Create a new Point2D
            Point2D point2D = Point2D.GetPoint2D();

            // Move the point by 5 units
            point2D.Move5();

            // Print the point
            Console.WriteLine(point2D);

            // Create a new Point
            IMovable point3 = Point.GetPoint();

            point3.Move5();

            Console.WriteLine(point3);
        }
    }
}
