Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.White;

const int HEIGHT = 30;
const int WIDTH = 100;
const int MENU_ITEMS = 3;
const int START_SPEED = 250;
const int MAX_SPEED = 60;
const int SPEED_DELTA = 20;


int halfWidth = (int)Math.Floor(WIDTH / 2f);
int halfHeight = (int)Math.Floor(HEIGHT / 2f);

const string PLAYER = "Ö";
const string TAIL = "O";
const string EMPTY = " ";
const string WALL = "X";
const string APPLE = "@";

int[] playerPos;
int[] applePos;
int[,] wall;

Queue<int[]> tail;
int tailLength;

int score;
int moveSpeed;

bool isGameOver;

void NewGame()
{
    isGameOver = false;
    tail = new();
    tailLength = 0;
    moveSpeed = START_SPEED;

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
        isValidInput = int.TryParse(key.ToString(), out difficulty) && difficulty > 0 && difficulty <= MENU_ITEMS;
    }
    while (!isValidInput);

    Console.Clear();

    //Draw walls
    wall = BuildLevel(difficulty);
    for (int i = 0; i < wall.GetLength(0); i++)
    {
        Console.SetCursorPosition(wall[i, 0], wall[i, 1]);
        Console.Write(WALL);
    }

    //Draw player
    playerPos = new int[2] { halfWidth + 2, halfHeight + 2 };
    Console.SetCursorPosition(playerPos[0], playerPos[1]);
    Console.Write(PLAYER);

    //Draw apple
    applePos = NewApplePos();
    Console.SetCursorPosition(applePos[0], applePos[1]);
    Console.Write(APPLE);

    //Draw score
    score = 0;
    Console.SetCursorPosition(0, 0);
    Console.Write($"Score: {score} ");
}

do
{
    NewGame();

    //set initial direction
    (int left, int top) moveDir = (1, 0);

    do // GameLoop
    {
        do // UpdateLoop
        {
            int[] newPos = { playerPos[0] + moveDir.left, playerPos[1] + moveDir.top };

            if (!IsCollision(newPos))
            {
                //Update tail           
                Console.SetCursorPosition(playerPos[0], playerPos[1]);
                Console.Write(TAIL);
                tail.Enqueue(playerPos);

                //remove tail tip
                if (tail.Count > tailLength)
                {
                    int[] tip = tail.Dequeue();
                    Console.SetCursorPosition(tip[0], tip[1]);
                    Console.Write(EMPTY);
                }

                //Update player
                playerPos = newPos;
                Console.SetCursorPosition(playerPos[0], playerPos[1]);
                Console.Write(PLAYER);

                //Check collision with apple
                if (applePos.SequenceEqual(playerPos))
                {
                    //Draw new apple
                    applePos = NewApplePos();
                    Console.SetCursorPosition(applePos[0], applePos[1]);
                    Console.Write(APPLE);

                    //Update score
                    score++;
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Score: {score} ");

                    //increase speed
                    moveSpeed = moveSpeed >= MAX_SPEED ? moveSpeed - (SPEED_DELTA - score) : moveSpeed;

                    //grow tail
                    tailLength++;
                }
            }
            else
            {
                isGameOver = true;
                break;
            }

            Thread.Sleep(moveSpeed);
        }
        while (!Console.KeyAvailable);

        if (!isGameOver)
        {
            //fetch input
            moveDir = Console.ReadKey(true).Key switch
            {
                ConsoleKey.LeftArrow => (-1, 0),
                ConsoleKey.RightArrow => (1, 0),
                ConsoleKey.UpArrow => (0, -1),
                ConsoleKey.DownArrow => (0, 1),
                _ => moveDir
            };
        }
    }
    while (!isGameOver);

    //Game Over
    Console.SetCursorPosition(halfWidth - 6, halfHeight);
    Console.Write(" Game Over! ");
    Console.SetCursorPosition(halfWidth - 9, halfHeight + 1);
    Console.Write($" Your score was {score}");
    Console.ReadKey(true);
    Console.Clear();

}
while (true);

int[,] BuildLevel(int difficulty)
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

int[,] GenerateWalls(int difficulty)
{
    int part = 0;
    int[,] generatedWall;

    //Easy level walls
    if (difficulty == 1)
    {
        generatedWall = new int[(WIDTH * 2 + (HEIGHT - 2) * 2), 2];
        for (int h = 0; h < HEIGHT; h++)
        {
            for (int w = 0; w < WIDTH; w++)
            {
                if ((h == 0 || h == HEIGHT - 1) || (w == 0 || w == WIDTH - 1))
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
        generatedWall = new int[HEIGHT - 2, 2];

        for (int i = 0; i < HEIGHT - 1; i++)
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
        generatedWall = new int[(HEIGHT - 2) + (WIDTH - 2), 2];

        for (int i = 1; i < HEIGHT - 1; i++)
        {
            for (int j = 1; j < WIDTH - 1; j++)
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

int[] NewApplePos()
{
    //find empty space for the apple
    int counter = 0;
    do
    {
        int[] tmp = new int[2] { Random.Shared.Next(1, WIDTH - 1), Random.Shared.Next(1, HEIGHT - 1) };
        if (!IsCollision(tmp)) return tmp;
        else counter++;
    } while (counter <= ((HEIGHT - 1) * (WIDTH - 1)));

    //if gameboard full then GameOver
    isGameOver = true;
    return new int[] { 0, 0 };
}

bool IsCollision(int[] pos)
{
    //check for walls
    for (int i = 0; i < wall.GetLength(0); i++)
    {
        if (wall[i, 0] == pos[0] && wall[i, 1] == pos[1]) return true;
    }

    //check for other objects
    if (playerPos.SequenceEqual(pos)) return true;
    else if (tail.Any(t => t.SequenceEqual(pos))) return true;
    else return false;
}
