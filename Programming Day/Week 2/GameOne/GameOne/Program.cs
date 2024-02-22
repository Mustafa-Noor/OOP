using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;

namespace GameOne
{
    
    internal class Program
    {
        static int px = 17, py = 15, ex1 = 90, ey1 = 4;
        static int contact1 = 0;
        static int bx = px +1;
        static int by = py;
        static bool bulletActive = false;
        static char bulletDir = 'r';
        static bool checkFirstEnemy = true;
        static int ebulletX1, ebulletY1;
        static bool bulletactiveE1 = false;
        static int counterforEnemy1 = 0;
        static int enemy1 = 100;
        public static char[,] Maze = new char[34, 99];

        static string[] mazeRows =
            {
        "################################################################################################",
        "#                                                                                              #",
        "#                                                                                              #",
        "#                                          #########                                           #",
        "#                                          ##     ##                                           #",
        "#                                          ##     ##                                           #",
        "#                                         ###     ###                                          #",
        "#                                                                                              #",
        "#                                                                                              #",
        "#                                                                                              #",
        "#                                                                                              #",
        "#######################              ###########################################################",
        "#                     #                                    #                                   #",
        "#                     #                                    #                                   #",
        "#                     #                                    #                                   #",
        "#                     #                                    #                                   #",
        "#                     #                                    #                                   #",
        "#                     #                                    #                                   #",
        "#              ########                                    #                                   #",
        "#                                                          #                                   #",
        "#                                                         ###                                  #",
        "#                                   ###                                                        #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "#                                    #                                                         #",
        "################################################################################################",
        "#                                   |              |                                           #",
        "#                                                                                              #",
        "################################################################################################"
    };
        static void Main(string[] args)
        {
            char[,] Maze = new char[34, 99];
            for (int i = 0; i < mazeRows.Length; i++)
            {
                for (int j = 0; j < mazeRows[i].Length; j++)
                {
                    Maze[i, j] = mazeRows[i][j];
                }
            }


             int px = 17, py = 15, ex1 = 90, ey1 = 4;
             int contact1 = 0;
             int bx = px + 1;
             int by = py;
             bool bulletActive = false;
             char bulletDir = 'r';
             bool checkFirstEnemy = true;
             int ebulletX1=0, ebulletY1=0;
             bool bulletactiveE1 = false;
             int counterforEnemy1 = 0;
             int enemy1 = 100;
        

             Console.Clear();
            printmaze(Maze);    // print the objects of the first level
            Console.SetCursorPosition(px, py);
            Console.Write("P");
            printenemy1(ex1,ey1);

            while (true)
            {

                Thread.Sleep(70);
                enemyShoot(ref ebulletX1, ref ebulletY1, ref bulletactiveE1);   // this checks if the bullet is active or not and give the bullet its coordinates
                moveEnemyBullet(ref ebulletX1, ref ebulletY1, ref bulletactiveE1, Maze); // this move the bullets of the enemies in the first level
                printEnemyBullets(ebulletX1, ebulletY1, bulletactiveE1); // this prints the bullets of the enemies in the first level

                // for the movement of the hero
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveHeroleft(Maze, ref px, ref py);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveHeroright(Maze, ref px, ref py);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveHeroup(Maze, ref px, ref py);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveHerodown(Maze, ref px, ref py);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    if (!bulletActive)
                    {
                        bx = px + 1;
                        by = py;
                        bulletActive = true;

                        bulletDir = 'r'; // shoots bullet towards right
                    }
                }
                if (Keyboard.IsKeyPressed(Key.V))
                {
                    if (!bulletActive)
                    {
                        bx = px - 1;
                        by = py;
                        bulletActive = true;
                        bulletDir = 'l'; // shoot bullets towards left
                    }
                }

                if (bulletActive)
                {
                    movefire(ref bx, ref by, Maze, bulletDir, ref bulletActive);
                }

               

                // calls of functions for the movement of enemies

                moveEnemy1(ref ex1, ref ey1, ref contact1, checkFirstEnemy);
            }
        }


        static void printmaze(char[,] Maze)
        {
            string print = "";
            for (int i = 0; i < 34; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    print += Maze[i, j];
                }
                print += "\n";
            }
            Console.Clear();
            Console.Write(print);
        }




        static void moveEnemyBullet(ref int ebulletX1, ref int ebulletY1, ref bool bulletactiveE1, char[,] Maze)
        {
            if (bulletactiveE1)
            {
                Console.SetCursorPosition(ebulletX1, ebulletY1);
                Console.Write( " ");
                ebulletX1 -= 2;
                if (ebulletX1 <= 0 || ebulletX1 < 35) // location of the bullet and where it can move
                {
                    bulletactiveE1 = false;
                }
                
            }
        }

        static void enemyShoot(ref int ebulletX1, ref int ebulletY1, ref bool bulletactiveE1)
        {
            if (!bulletactiveE1)
            {
                ebulletX1 = ex1 -2;
                ebulletY1 = ey1;
                bulletactiveE1 = true;
            }
        }

        static void printEnemyBullets(int ebulletX1, int ebulletY1, bool bulletactiveE1)
        {
            if (bulletactiveE1)
            {
                
                Console.SetCursorPosition(ebulletX1, ebulletY1);
                Console.Write("<");
            }
        }


        static void movefire(ref int bx, ref int by, char[,] Maze, char bulletDir, ref bool bulletActive )
        {
            removefire(bx, by);
            int mazeWidth = Maze.GetLength(0);
            // r means right direction
            if (bulletDir == 'r')
            {
                if (bx + 3 < mazeWidth && Maze[bx + 3, by] != '#')
                {
                    bx += 3; // Move right
                }
                else
                {

                    bulletActive = false;
                    removefire(bx,by);
                }


            }
            //l means left direction
            else if (bulletDir == 'l')
            {
                if (Maze[bx - 3, by] != '#')
                { bx -= 3; }
                else
                {

                    bulletActive = false;
                    removefire(bx, by);
                }

            }

            
            if(bulletActive)
            {
                Console.SetCursorPosition(bx, by);
                Console.Write("o");
            }
        }

        static void removefire(int bx, int by)
        {
            Console.SetCursorPosition(bx, by);
            Console.Write(" ");
        }

        static void moveHeroleft(char[,] Maze, ref int px, ref int py)
        {
            if (Maze[px - 1, py] == ' ')
            {
                Maze[px, py] = ' ';
                Console.SetCursorPosition(px, py);
                Console.Write(" ");
                px--;
                Console.SetCursorPosition(px, py);
                Console.Write("P");
            }
            
        }

        static void moveHeroright(char[,] Maze, ref int px, ref int py)
        {
            if (Maze[px + 1, py] == ' ')
            {
                Maze[px, py] = ' ';
                Console.SetCursorPosition(px, py);
                Console.Write(" ");
                px++;
                Console.SetCursorPosition(px, py);
                Console.Write("P");
            }
        }

        static void moveHeroup(char[,] Maze, ref int px, ref int py)
        {
            if (Maze[px, py - 1] == ' ')
            {
                Maze[px, py] = ' ';
                Console.SetCursorPosition(px, py);
                Console.Write(" ");
                py--;
                Console.SetCursorPosition(px, py);
                Console.Write("P"); ;
            }
        }

        static void moveHerodown(char[,] Maze, ref int px, ref int py )
        {
            if(Maze[px, py + 1] == ' ')
            {
                Maze[px, py] = ' ';
                Console.SetCursorPosition(px, py);
                Console.Write(" ");
                py++;
                Console.SetCursorPosition(px, py);
                Console.Write("P");
            }
        }
        // to move hero down
        

        // checks if enemy 1 is alive then moves it
        static void moveEnemy1(ref int ex1, ref int ey1, ref int contact1, bool checkFirstEnemy)
        {

           
            
                removeEnemy1(ex1, ey1);
                if (checkFirstEnemy)
                {
                    if (contact1 == 0)
                    {
                        ey1 = ey1 + 1;
                    }
                    if (ey1 == 9)
                    {
                        contact1 = 1;
                    }
                    if (contact1 == 1)
                    {
                        ey1 = ey1 - 1;
                    }

                    if (ey1 == 1)
                    {
                        contact1 = 0;
                    }

                    printenemy1(ex1,ey1);
                }

            
        }

        

        static void removeEnemy1(int ex1, int ey1)
        {
            Console.SetCursorPosition(ex1, ey1);
            Console.Write(" ");
            
        }

        // functions for the printing of the enemies
        static void printenemy1(int ex1, int ey1)
        {
            
            Console.SetCursorPosition(ex1, ey1);
            Console.Write( "@");
            
        }



    }
}
