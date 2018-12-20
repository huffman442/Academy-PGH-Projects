using System;
namespace GameOLife
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int alive = 1;
            Random rnd = new Random();
            int sizeOfGrid = 20;
            int[,] grid = new int[sizeOfGrid, sizeOfGrid];
            for (int i = 0; i < sizeOfGrid; i++)
            {
                for (int j = 0; j < sizeOfGrid; j++)
                {
                    if (rnd.Next(0, 9) < 3)
                    {
                        grid[i, j] = 0;
                    }
                    else
                    {
                        grid[i, j] = alive;
                    }
                }
            }


            while (true)
            {
                int[,] tempGrid = new int[sizeOfGrid, sizeOfGrid];
                for (int i = 0; i < sizeOfGrid; i++)
                {
                    for (int j = 0; j < sizeOfGrid; j++)
                    {
                        if (grid[i, j] == alive)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                        int counter = 0;
                        if (i > 0 && j > 0)
                        {
                            if (grid[i - 1, j - 1] == alive)
                            {
                                counter = counter + 1;
                            }

                        }
                        if (i > 0 && j < sizeOfGrid - 1)
                        {
                            if (grid[i - 1, j + 1] == alive)
                            {
                                counter = counter + 1;
                            }

                        }
                        if (i < sizeOfGrid - 1 && j > 0)
                        {
                            if (grid[i + 1, j - 1] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (i < sizeOfGrid - 1 && j < sizeOfGrid - 1)
                        {
                            if (grid[i + 1, j + 1] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (i > 0)
                        {
                            if (grid[i - 1, j] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (j > 0)
                        {
                            if (grid[i, j - 1] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (i < sizeOfGrid - 1)
                        {
                            if (grid[i + 1, j] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (j < sizeOfGrid - 1)
                        {
                            if (grid[i, j + 1] == alive)
                            {
                                counter = counter + 1;
                            }
                        }
                        if (grid[i, j] != alive && counter == 3)
                        {
                            tempGrid[i, j] = 1;

                        }
                        if (grid[i, j] == alive && counter == 2)
                        {
                            tempGrid[i, j] = 1;
                        }
                        else if (grid[i, j] == alive && counter == 3)
                        {
                            tempGrid[i, j] = 1;
                        }
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                grid = tempGrid;
            }
        }
    }
}