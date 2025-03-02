using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp
{
    internal class Point
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
        /// Move the point by 10 units
        /// </summary>
        public virtual void Move10()
        {
            X += 10;
        }

        /// <summary>
        /// Print the point
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"X: {X}";
    }
}
