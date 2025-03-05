using PointSOAApp.Model;
using System;
using System.Collections.Generic;

namespace PointSOAApp.DAO
{
    /// <summary>
    /// Implementation of the IPointDAO interface, managing a collection of Point objects.
    /// </summary>
    public class PointDAOImpl : IPointDAO
    {
        /// <summary>
        /// A static list that stores all point instances.
        /// </summary>
        private static readonly List<Point> points = new();

        /// <summary>
        /// Gets a copy of the list containing all points.
        /// </summary>
        public static List<Point> Points => new(points);

        /// <summary>
        /// Adds a new point to the data store.
        /// </summary>
        /// <param name="point">The Point object to add.</param>
        public void AddPoint(Point point)
        {
            if (point == null) throw new ArgumentNullException(nameof(point));

            // Check if the point already exists in the data store.
            if (points.Exists(p => p.X == point.X))
                throw new ArgumentException("Point already exists in the data store.", nameof(point));

            points.Add(point);
        }

        /// <summary>
        /// Updates an existing point in the data store.
        /// </summary>
        /// <param name="point">The Point object containing updated values.</param>
        public void UpdatePoint(Point point)
        {
            if (point == null) throw new ArgumentNullException(nameof(point));

            int index = points.FindIndex(p => p.X == point.X);
            if (index == -1) throw new ArgumentException("Point not found in the data store.", nameof(point));

            points[index] = point;
        }

        /// <summary>
        /// Deletes a specific point from the data store.
        /// </summary>
        /// <param name="point">The Point object to delete.</param>
        public void DeletePoint(Point point)
        {
            if (point == null) throw new ArgumentNullException(nameof(point));

            if (!points.Remove(point))
                throw new ArgumentException("Point not found in the data store.", nameof(point));
        }

        /// <summary>
        /// Retrieves all points from the data store.
        /// </summary>
        /// <returns>A list of Point objects.</returns>
        public List<Point> GetPoints()
        {
            return new List<Point>(points);
        }

        /// <summary>
        /// Retrieves a point by its index in the data store.
        /// </summary>
        /// <param name="x">The X-coordinate of the point to retrieve.</param>
        /// <returns>The Point object with the specified X-coordinate.</returns>
        public Point GetPoint(int x)
        {
            Point? point = points.Find(p => p.X == x);
            if (point == null) throw new ArgumentException("Point not found in the data store.", nameof(x));
            return point;
        }
    }
}