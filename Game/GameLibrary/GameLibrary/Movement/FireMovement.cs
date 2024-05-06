using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLibrary
{
    public class FireMovement : IMovement
    {
        private int Speed;
        private Point Boundary;
        private FireDirection Direction;

        public FireMovement(int speed, Point boundary, FireDirection direction)
        {
            this.Speed = speed;
            this.Boundary = boundary;
            this.Direction = direction;
        }

        public Point Move(Point currentLocation)
        {
            // Check the direction of the bullet and move accordingly
            if (Direction == FireDirection.Up)
            {
                currentLocation.Y -= Speed; // Move upward
            }
            else if (Direction == FireDirection.Down)
            {
                currentLocation.Y += Speed; // Move downward
            }

            // Check if the bullet is out of bounds and remove it if needed
            if (currentLocation.Y < 0 || currentLocation.Y > Boundary.Y)
            {
                currentLocation = new Point(-100, -100); // Move the bullet out of bounds (you can adjust this)
            }

            return currentLocation;
        }
    }
}
