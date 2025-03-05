using System;
using System.Collections.Generic;
using PointSOAApp.DAO;
using PointSOAApp.DTO;
using PointSOAApp.Model;

namespace PointSOAApp.Service
{
    /// <summary>
    /// Implementation of the IPointService interface, handling business logic and conversions between DTO and DAO models.
    /// </summary>
    public class PointServiceImpl : IPointService
    {
        private readonly IPointDAO _pointDAO;

        /// <summary>
        /// Initializes a new instance of the <see cref="PointServiceImpl"/> class.
        /// </summary>
        /// <param name="pointDAO">The data access object for points.</param>
        public PointServiceImpl(IPointDAO pointDAO)
        {
            _pointDAO = pointDAO;
        }

        /// <summary>
        /// Converts a PointDTO to a Point entity.
        /// </summary>
        /// <param name="dto">The PointDTO object.</param>
        /// <returns>A Point entity.</returns>
        private Point ConvertToEntity(PointDTO dto)
        {
            return new Point { X = dto.X};
        }

        /// <summary>
        /// Converts a Point entity to a PointDTO.
        /// </summary>
        /// <param name="entity">The Point entity.</param>
        /// <returns>A PointDTO object.</returns>
        private PointDTO ConvertToDTO(Point entity)
        {
            return new PointDTO(entity.X);
        }

        public void AddPoint(PointDTO pointDto)
        {
            _pointDAO.AddPoint(ConvertToEntity(pointDto));
        }

        public void UpdatePoint(PointDTO pointDto)
        {
            _pointDAO.UpdatePoint(ConvertToEntity(pointDto));
        }

        public void DeletePoint(PointDTO pointDto)
        {
            _pointDAO.DeletePoint(ConvertToEntity(pointDto));
        }

        public List<PointDTO> GetPoints()
        {
            var points = _pointDAO.GetPoints();
            var dtoList = new List<PointDTO>();
            foreach (var point in points)
            {
                dtoList.Add(ConvertToDTO(point));
            }
            return dtoList;
        }

        public PointDTO GetPointByIndex(int x)
        {
            return ConvertToDTO(_pointDAO.GetPoint(x));
        }
    }
}
