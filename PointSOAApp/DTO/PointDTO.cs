using System;

namespace PointSOAApp.DTO
{
    /// <summary>
    /// Data Transfer Object (DTO) for representing a point in a one-dimensional space.
    /// </summary>
    public class PointDTO : IComparable<PointDTO>, IEquatable<PointDTO>
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointDTO"/> class.
        /// </summary>
        public PointDTO() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointDTO"/> class with specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate.</param>
        public PointDTO(int x)
        {
            X = x;
        }

        /// <summary>
        /// Compares the current point with another point based on the X-coordinate.
        /// </summary>
        /// <param name="other">The other point to compare.</param>
        /// <returns>A negative value if this point is smaller, zero if equal, and a positive value if this point is greater.</returns>
        public int CompareTo(PointDTO? other)
        {
            if (other == null) return 1;
            return X.CompareTo(other.X);
        }

        /// <summary>
        /// Determines whether the current point is equal to another point.
        /// </summary>
        /// <param name="other">The other point to compare.</param>
        /// <returns>True if both points have the same X and Y coordinates, otherwise false.</returns>
        public bool Equals(PointDTO? other)
        {
            if (other == null) return false;
            return X == other.X;
        }

        /// <summary>
        /// Determines whether the current point is equal to another object.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>True if the object is a PointDTO and has the same coordinates, otherwise false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not PointDTO other) return false;
            return Equals(other);
        }

        /// <summary>
        /// Gets the hash code for the point.
        /// </summary>
        /// <returns>The hash code of the point based on its coordinates.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        /// <summary>
        /// Returns a string representation of the point.
        /// </summary>
        /// <returns>A string in the format "Point: (X, Y)".</returns>
        public override string ToString()
        {
            return $"PointDTO: ({X})";
        }

        // =================== Operator Overloads ===================

        public static bool operator >(PointDTO? left, PointDTO? right) => left is not null && (right is null || left.X > right.X);
        public static bool operator <(PointDTO? left, PointDTO? right) => right is not null && (left is null || left.X < right.X);
        public static bool operator >=(PointDTO? left, PointDTO? right) => left is not null && (right is null || left.X >= right.X);
        public static bool operator <=(PointDTO? left, PointDTO? right) => right is not null && (left is null || left.X <= right.X);
        public static bool operator ==(PointDTO? left, PointDTO? right) => left?.Equals(right) ?? right is null;
        public static bool operator !=(PointDTO? left, PointDTO? right) => !(left == right);
    }
}