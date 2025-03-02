using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    /// <summary>
    /// This class is responsible for moving the object
    /// </summary>
    class MovingSpace
    {
        // Interface object
        private IMovable Movable;

        // Dependency Injection (DI) - Invertion of Control (IoC)
        public MovingSpace(IMovable movable)
        {
            this.Movable = movable;
        }

        /// <summary>
        /// Make a move
        /// </summary>
        public void MakeMove()
        {
            Movable.Move5();
        }
    }
}
