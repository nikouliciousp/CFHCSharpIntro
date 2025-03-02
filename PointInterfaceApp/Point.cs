using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    internal class Point : IMovable
    {
        public int X { get; set; }

        /// <summary>
        /// Get a new point
        /// </summary>
        /// <returns></returns>
        public static Point GetPoint()
        {
            return new Point();
        }

        /// <summary>
        /// Get a new point
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X;
        }

        /// <summary>
        /// Get the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        /// <summary>
        /// Move the point by 10 units
        /// </summary>
        public virtual void Move10()
        {
            X += 10;
        }

        /// <summary>
        /// Move the point by 5 units
        /// </summary>
        public virtual void Move5()
        {
            X += 5;
        }

        /// <summary>
        /// Print the point
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"X: {X}";
    }
}
