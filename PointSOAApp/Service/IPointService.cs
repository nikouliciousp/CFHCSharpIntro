using PointSOAApp.DTO;

namespace PointSOAApp.Service
{
    /// <summary>
    /// Interface for point-related services, providing business logic operations.
    /// </summary>
    public interface IPointService
    {
        /// <summary>
        /// Adds a new point to the system.
        /// </summary>
        /// <param name="pointDto">The PointDTO object to add.</param>
        void AddPoint(PointDTO pointDto);

        /// <summary>
        /// Updates an existing point in the system.
        /// </summary>
        /// <param name="pointDto">The PointDTO object with updated values.</param>
        void UpdatePoint(PointDTO pointDto);

        /// <summary>
        /// Deletes a point from the system.
        /// </summary>
        /// <param name="pointDto">The PointDTO object to delete.</param>
        void DeletePoint(PointDTO pointDto);

        /// <summary>
        /// Retrieves all points from the system.
        /// </summary>
        /// <returns>A list of PointDTO objects.</returns>
        List<PointDTO> GetPoints();

        /// <summary>
        /// Retrieves a point by its X-coordinate.
        /// </summary>
        /// <param name="x">The X-coordinate of the point to retrieve.</param>
        /// <returns>The PointDTO object with the specified X-coordinate.</returns>
        PointDTO GetPointByIndex(int x);
    }
}
