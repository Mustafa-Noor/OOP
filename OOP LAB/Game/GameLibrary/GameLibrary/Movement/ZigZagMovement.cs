using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLibrary
{
    public class ZigZagMovement:IMovement
    {
        private int Speed;
        private Point Boundary;
        private HorizontalDirection Direction;
        private int count;
        private int Offset = 90;
        public ZigZagMovement(int speed, Point boundry)
        {
            this.Speed = speed;
            this.Boundary = boundry;
            this.Direction = HorizontalDirection.Right;
            count = 0;
        }

        public Point Move(Point currentLocation)
        {
            if (Direction == HorizontalDirection.Right)
            {
                if (count < 5)
                {
                    currentLocation.X += Speed;
                    currentLocation.Y -= Speed;
                }
                else if (count >= 5 && count < 10)
                {
                    currentLocation.X += Speed;
                    currentLocation.Y += Speed;
                }
            }
            else if (Direction == HorizontalDirection.Left)
            {
                if (count < 5)
                {
                    currentLocation.X -= Speed;
                    currentLocation.Y += Speed;
                }
                else if (count >= 5 && count < 10)
                {
                    currentLocation.X -= Speed;
                    currentLocation.Y -= Speed;
                }
            }
            if ((currentLocation.X + Offset) >= Boundary.X)
            {
                Direction = HorizontalDirection.Left;

            }
            else if ((currentLocation.X + Speed) <= 0)
            {
                Direction = HorizontalDirection.Right;

            }
            if (count == 10)
            {
                count = 0;
            }
            count++;
            return currentLocation;
        }


    }
}
