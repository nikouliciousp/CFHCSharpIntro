using System;
using System.Collections.Generic;

namespace PointMVCMonolithicApp
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
        /// A static list that stores all point instances.
        /// </summary>
        private static readonly List<Point> points = new();

        /// <summary>
        /// Gets a copy of the list containing all points.
        /// </summary>
        public static List<Point> Points => new(points);

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

        // =================== CRUD Operations ===================

        /// <summary>
        /// Inserts the current point into the list.
        /// </summary>
        public void Insert()
        {
            points.Add(this);
        }

        /// <summary>
        /// Updates the X-coordinate of the current point.
        /// </summary>
        /// <param name="x">The new X value.</param>
        /// <returns>True if the update was successful, otherwise false.</returns>
        public bool Update(int x)
        {
            int index = GetPointIndex();
            if (index < 0)
            {
                return false;
            }
            points[index].X = x;
            return true;
        }

        /// <summary>
        /// Deletes the current point from the list.
        /// </summary>
        /// <returns>The deleted point if successful, otherwise null.</returns>
        public Point? Delete()
        {
            return points.Remove(this) ? this : null;
        }

        /// <summary>
        /// Gets the current point from the list if it exists.
        /// </summary>
        /// <returns>The point if found, otherwise null.</returns>
        public Point? GetPoint()
        {
            int index = GetPointIndex();
            return index >= 0 ? points[index] : null;
        }

        /// <summary>
        /// Finds the index of the current point in the list.
        /// </summary>
        /// <returns>The index of the point if found, otherwise -1.</returns>
        private int GetPointIndex()
        {
            return points.IndexOf(this);
        }

        // =================== SERVICE Operations ===================

        /// <summary>
        /// Inserts a new point into the list.
        /// </summary>
        public void InsertPointService()
        {
            Insert();
        }

        /// <summary>
        /// Updates the X-coordinate of the current point.
        /// </summary>
        /// <param name="x"></param>
        public void UpdatePointService(int x)
        {
            try
            {
                if (!Update(x))
                {
                    throw new InvalidOperationException("Point not found.");
                }
                else
                {
                    Console.WriteLine("Point updated successfully.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Deletes the current point from the list.
        /// </summary>
        /// <returns></returns>
        public Point? DeletePointService()
        {
            try
            {
                Point? deletedPoint = Delete();
                if (deletedPoint == null)
                {
                    throw new InvalidOperationException("Point not found.");
                }
                else
                {
                    Console.WriteLine("Point deleted successfully.");
                    return deletedPoint;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets the current point from the list if it exists.
        /// </summary>
        /// <returns></returns>
        public Point? GetPointService()
        {
            try
            {
                Point? point = GetPoint();
                if (point == null)
                {
                    throw new InvalidOperationException("Point not found.");
                }
                else
                {
                    Console.WriteLine("Point found successfully.");
                    return point;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets all points from the list.
        /// </summary>
        /// <returns></returns>
        public static List<Point> GetPointsService()
        {
            try
            {
                if (points.Count == 0)
                {
                    throw new InvalidOperationException("No points found.");
                }
                else
                {
                    Console.WriteLine("Points retrieved successfully.");
                    return Points;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Point>();
            }
        }
    }
}
