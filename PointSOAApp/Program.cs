using System;
using System.Collections.Generic;
using PointSOAApp.DAO;
using PointSOAApp.DTO;
using PointSOAApp.Model;
using PointSOAApp.Service;

namespace PointSOAApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize DAO and Service
            IPointDAO pointDAO = new PointDAOImpl();
            IPointService pointService = new PointServiceImpl(pointDAO);

            // Adding points
            pointService.AddPoint(new PointDTO(5));
            pointService.AddPoint(new PointDTO(10));
            pointService.AddPoint(new PointDTO(15));

            // Retrieving and displaying all points
            Console.WriteLine("All Points:");
            foreach (var point in pointService.GetPoints())
            {
                Console.WriteLine(point);
            }

            // Getting a specific point
            int searchX = 10;
            try
            {
                PointDTO foundPoint = pointService.GetPointByIndex(searchX);
                Console.WriteLine($"Point found: {foundPoint}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Updating a point
            pointService.UpdatePoint(new PointDTO(8));
            Console.WriteLine("Updated Points:");
            foreach (var point in pointService.GetPoints())
            {
                Console.WriteLine(point);
            }

            // Deleting a point
            pointService.DeletePoint(new PointDTO(5));
            Console.WriteLine("Points after deletion:");
            foreach (var point in pointService.GetPoints())
            {
                Console.WriteLine(point);
            }
        }
    }
}
