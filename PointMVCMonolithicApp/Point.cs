using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointMVCMonolithicApp
{
    /// <summary>
    /// This class represents a point
    /// </summary>
    class Point : IComparable<Point>, IEquatable<Point>
    {
        public int X { get; set; }

        // A List of Points
        private static readonly List<Point> points = new();

        // Properties
        public static List<Point> Points { get { return new List<Point>(points); } }

        /// <summary>
        /// This method compares two points for equality
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Point? other)
        {
            if (other == null) return 1;
            return X - other.X;
        }

        /// <summary>
        /// This method equals two points via the CompareTo method
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Point? other)
        {
            if (other == null) return false;
            return CompareTo(other) == 0;
        }

        /// <summary>
        /// This method equals two points via the CompareTo method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is null || GetType() != obj.GetType())
            {
                return false;
            }
            return CompareTo((Point)obj) == 0;
        }

        /// <summary>
        /// This method returns the hash code of a point
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        /// <summary>
        /// This method returns the string representation of a point
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Point: {X}";
        }

        /// <summary>
        /// This method overrides the > operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(Point? left, Point? right)
        {
            if (left is null) return false;
            if (right is null) return true;
            return left.CompareTo(right) > 0;
        }

        /// <summary>
        /// This method overrides the < operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(Point? left, Point? right)
        {
            if (left is null) return right is not null;
            if (right is null) return false;
            return left.CompareTo(right) < 0;
        }

        /// <summary>
        /// This method overrides the >= operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(Point? left, Point? right)
        {
            if (left is null) return right is null;
            if (right is null) return true;
            return left.CompareTo(right) >= 0;
        }

        /// <summary>
        /// This method overrides the <= operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(Point? left, Point? right)
        {
            if (left is null) return true;
            if (right is null) return false;
            return left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// This method overrides the == operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Point? left, Point? right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        /// <summary>
        /// This method overrides the != operator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(Point? left, Point? right)
        {
            return !(left == right);
        }
    }
}
