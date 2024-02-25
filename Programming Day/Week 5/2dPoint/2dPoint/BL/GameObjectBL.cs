using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dPoint
{
    internal class GameObjectBL
    {
        public char[,] Shape;
        public PointBL StartingPoint;
        public BoundaryBL Premises;
        public string Direction;

        public GameObjectBL()
        {
            Shape = new char[,] { { '-', '-', '-' } };
            StartingPoint = new PointBL(0,0);
            Premises = new BoundaryBL();
            Direction = "LeftToRight";
        }

        public GameObjectBL(char[,] shape, PointBL startingPoint)
        {
            Shape = shape;
            StartingPoint = startingPoint;
            Premises = new BoundaryBL();
            Direction = "LeftToRight";
        }

        public GameObjectBL(char[,] shape, PointBL startingPoint, BoundaryBL premises, string direction)
        {
            Shape = shape;
            StartingPoint = startingPoint;
            Premises = premises;
            Direction = direction;
        }

        public void Move()
        {
            switch (Direction)
            {
                case "LeftToRight":
                    if (StartingPoint.x < Premises.TopRight.x)
                    {
                        StartingPoint.x++;
                    }
                    break;
                case "RightToLeft":
                    if (StartingPoint.x > Premises.TopLeft.x)
                    {
                        StartingPoint.x--;
                    }
                    break;
                case "Patrol":
                    if (StartingPoint.x > Premises.TopLeft.x && StartingPoint.x < Premises.TopRight.x)
                    {
                        StartingPoint.x--;
                    }
                    else if (StartingPoint.x == Premises.TopLeft.x)
                    {
                        Direction = "RightToLeft";
                    }
                    else if (StartingPoint.x == Premises.TopRight.x)
                    {
                        Direction = "LeftToRight";
                    }
                    break;
                case "Projectile":
                    // Implement projectile logic
                    break;
                case "Diagonal":
                    if (StartingPoint.x < Premises.TopRight.x && StartingPoint.y > Premises.TopRight.y)
                    {
                        StartingPoint.x++;
                        StartingPoint.y--;
                    }
                    break;
                default:
                    break;
            }
        }

        public void Erase()
        {
           
            Console.Clear();
        }

        public void Draw()
        {
            // Render the shape on the console
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(Shape[i, j]);
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
