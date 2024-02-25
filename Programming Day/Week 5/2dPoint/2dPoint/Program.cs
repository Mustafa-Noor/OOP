using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2dPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', '@', '@' }, { '@', '@', '@' }, { '@', '@', '@' }, { '@', '@', '@' }, { '@', '@', '@' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { '@', '@', '@' } };

            BoundaryBL b = new BoundaryBL(new PointBL(0, 0), new PointBL(0, 90), new PointBL(90, 0), new PointBL(90, 90));
            GameObjectBL g1 = new GameObjectBL(triangle, new PointBL(5, 5),b, "LeftToRight");
            GameObjectBL g2 = new GameObjectBL(opTriangle, new PointBL(30, 60), b, "RightToLeft");

            List<GameObjectBL> gameObjects = new List<GameObjectBL>();
            gameObjects.Add(g1);
            gameObjects.Add(g2);

            while (true)
            {
                Thread.Sleep(2000);

                foreach (GameObjectBL g in gameObjects)
                {
                    g.Erase();
                    g.Move();
                    g.Draw();
                }
            }
        }
    }
}
