using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSOAApp.Model
{
    /// <summary>
    /// This class represents a point in a one-dimensional space.
    /// </summary>
    public class Point : IComparable<Point>, IEquatable<Point>
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Compares the current point with another point based on the X-coordinate.
        /// </summary>
        /// <param name="other">The other point to compare.</param>
        /// <returns>
        /// A negative value if this point is smaller, zero if equal, 
        /// and a positive value if this point is greater.
        /// </returns>
        public int CompareTo(Point? other)
        {
            if (other == null) return 1;
            return X.CompareTo(other.X);
        }

        /// <summary>
        /// Determines whether the current point is equal to another point.
        /// </summary>
        /// <param name="other">The other point to compare.</param>
        /// <returns>True if both points have the same X-coordinate, otherwise false.</returns>
        public bool Equals(Point? other)
        {
            if (other == null) return false;
            return X == other.X;
        }

        /// <summary>
        /// Determines whether the current point is equal to another object.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>True if the object is a Point and has the same X-coordinate, otherwise false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Point other) return false;
            return Equals(other);
        }

        /// <summary>
        /// Gets the hash code for the point.
        /// </summary>
        /// <returns>The hash code of the point based on its X-coordinate.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        /// <summary>
        /// Returns a string representation of the point.
        /// </summary>
        /// <returns>A string in the format "Point: X".</returns>
        public override string ToString()
        {
            return $"Point: {X}";
        }

        // =================== Operator Overloads ===================

        /// <summary>
        /// Checks if one point is greater than another.
        /// </summary>
        public static bool operator >(Point? left, Point? right)
        {
            if (left is null) return false;
            if (right is null) return true;
            return left.X > right.X;
        }

        /// <summary>
        /// Checks if one point is less than another.
        /// </summary>
        public static bool operator <(Point? left, Point? right)
        {
            if (left is null) return right is not null;
            if (right is null) return false;
            return left.X < right.X;
        }

        /// <summary>
        /// Checks if one point is greater than or equal to another.
        /// </summary>
        public static bool operator >=(Point? left, Point? right)
        {
            if (left is null) return right is null;
            if (right is null) return true;
            return left.X >= right.X;
        }

        /// <summary>
        /// Checks if one point is less than or equal to another.
        /// </summary>
        public static bool operator <=(Point? left, Point? right)
        {
            if (left is null) return true;
            if (right is null) return false;
            return left.X <= right.X;
        }

        /// <summary>
        /// Checks if two points are equal.
        /// </summary>
        public static bool operator ==(Point? left, Point? right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        /// <summary>
        /// Checks if two points are not equal.
        /// </summary>
        public static bool operator !=(Point? left, Point? right)
        {
            return !(left == right);
        }
    }
}
