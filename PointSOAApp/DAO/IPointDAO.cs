using PointSOAApp.Model;
using System.Collections.Generic;

namespace PointSOAApp.DAO
{
    /// <summary>
    /// Interface for data access operations related to Point objects.
    /// Provides methods for CRUD (Create, Read, Update, Delete) operations.
    /// </summary>
    public interface IPointDAO
    {
        /// <summary>
        /// Adds a new point to the data store.
        /// </summary>
        /// <param name="point">The Point object to add.</param>
        void AddPoint(Point point);

        /// <summary>
        /// Updates an existing point in the data store.
        /// </summary>
        /// <param name="point">The Point object containing updated values.</param>
        void UpdatePoint(Point point);

        /// <summary>
        /// Deletes a specific point from the data store.
        /// </summary>
        /// <param name="point">The Point object to delete.</param>
        void DeletePoint(Point point);

        /// <summary>
        /// Retrieves all points from the data store.
        /// </summary>
        /// <returns>A list of Point objects.</returns>
        List<Point> GetPoints();

        /// <summary>
        /// Retrieves a point by its index in the data store.
        /// </summary>
        /// <param name="x">The index of the point to retrieve.</param>
        /// <returns>The Point object at the specified index, or null if not found.</returns>
        Point GetPoint(int x);
    }
}
