using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSnake2
{
    internal class GameBoard
    {
        public const string WALL = "X";
        public int Width { get; }
        public int Height { get; }


        private int[,] wall;

        private readonly int halfWidth;
        private readonly int halfHeight;

        public GameBoard(int width, int height)
        {
            Width = width;
            Height = height;

            halfHeight = height / 2;
            halfWidth = width / 2;
        }

        public void NewGame()
        {

        }

        public void DrawLevel(int difficulty)
        {
            wall = BuildLevel(difficulty);
            for (int i = 0; i < wall.GetLength(0); i++)
            {
                Console.SetCursorPosition(wall[i, 0], wall[i, 1]);
                Console.Write(WALL);
            }
        }

        public int DifficultyMenu()
        {
            //Show Menu
            Console.SetCursorPosition(halfWidth - 4, halfHeight - 2);
            Console.Write("ConSnake");
            Console.SetCursorPosition(halfWidth - 20, halfHeight - 1);
            Console.Write("Press the coresponding key to start level");
            Console.SetCursorPosition(halfWidth - 5, halfHeight);
            Console.Write("1: Easy");
            Console.SetCursorPosition(halfWidth - 5, halfHeight + 1);
            Console.Write("2: Medium");
            Console.SetCursorPosition(halfWidth - 5, halfHeight + 2);
            Console.Write("3: Hard");

            //Fetch level selection
            int difficulty;
            bool isValidInput;
            do
            {
                char key = Console.ReadKey(true).KeyChar;
                isValidInput = int.TryParse(key.ToString(), out difficulty) && difficulty > 0 ;
            }
            while (!isValidInput);

            return difficulty;
        }

        private int[,] BuildLevel(int difficulty)
        {
            //build outer walls
            int[,] outerWall = GenerateWalls(1);

            if (difficulty > 1)
            {
                //build inner walls
                int[,] innerWall = GenerateWalls(difficulty);

                //Combine all wallparts in one array
                int outerWallParts = outerWall.GetLength(0) * outerWall.GetLength(1);
                int innerWallParts = innerWall.GetLength(0) * innerWall.GetLength(1);

                int[,] combinedWall = new int[outerWallParts + innerWallParts, 2];
                Array.Copy(outerWall, combinedWall, outerWallParts);
                Array.Copy(innerWall, 0, combinedWall, outerWallParts, innerWallParts);

                return combinedWall;
            }
            else return outerWall;
        }

        private int[,] GenerateWalls(int difficulty)
        {
            int part = 0;
            int[,] generatedWall;

            //Easy level walls
            if (difficulty == 1)
            {
                generatedWall = new int[(Width * 2 + (Height - 2) * 2), 2];
                for (int h = 0; h < Height; h++)
                {
                    for (int w = 0; w < Width; w++)
                    {
                        if ((h == 0 || h == Height - 1) || (w == 0 || w == Height - 1))
                        {
                            generatedWall[part, 0] = w;
                            generatedWall[part, 1] = h;
                            part++;
                        }
                    }
                }
            }
            //Medium level walls
            else if (difficulty == 2)
            {
                generatedWall = new int[Height - 2, 2];

                for (int i = 0; i < Height - 1; i++)
                {
                    if (i != halfHeight)
                    {
                        generatedWall[part, 0] = halfWidth;
                        generatedWall[part, 1] = i;
                        part++;
                    }
                }
            }
            //Hard level walls
            else if (difficulty == 3)
            {
                generatedWall = new int[(Height - 2) + (Width - 2), 2];

                for (int i = 1; i < Height - 1; i++)
                {
                    for (int j = 1; j < Width - 1; j++)
                    {
                        if ((i == halfHeight ^ j == halfWidth) && (i == halfHeight - 1 ^ i != halfHeight + 1) && (j == halfWidth - 1 ^ j != halfWidth + 1))
                        {
                            generatedWall[part, 0] = j;
                            generatedWall[part, 1] = i;
                            part++;
                        }
                    }
                }
            }
            else generatedWall = new int[0, 0];

            return generatedWall;
        }
    }
}
