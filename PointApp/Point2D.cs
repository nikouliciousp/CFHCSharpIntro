using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp
{
    internal class Point2D: Point
    {
        public int Y { get; set; }

        //public Point2D() : base()
        //{
        //    Y = 0;
        //}

        /// <summary>
        /// Static method to get a new Point2D
        /// </summary>
        /// <returns></returns>
        public static Point2D GetPoint2D()
        {
            return new Point2D();
        }

        public override bool Equals(object? obj)
        {
            return obj is Point2D d &&
                   X == d.X &&
                   Y == d.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <summary>
        /// Move the point by 10 units
        /// </summary>
        public override void Move10()
        {
            base.Move10();
            Y += 10;
        }

        /// <summary>
        /// Print the point
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{base.ToString()}, Y: {Y}";


    }
}
