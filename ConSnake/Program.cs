Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.White;

const int HEIGHT = 30;
const int WIDTH = 100;

const string PLAYER = "Ö";
const string TAIL = "O";
const string EMPTY = " ";
const string WALL = "X";
const string APPLE = "@";

int[] playerPos;
int[] applePos;

Queue<int[]> tail;
int tailLength;

int score;
int moveSpeed = 250;

bool isGameOver;

int halfWidth = (int)Math.Floor(WIDTH / 2f);
int halfHeight = (int)Math.Floor(HEIGHT / 2f);

void NewGame()
{
    isGameOver = false;
    tail = new();
    tailLength = 0;

    Console.SetCursorPosition(halfWidth - 4, halfHeight);
    Console.Write("ConSnake");
    Console.SetCursorPosition(halfWidth - 14, halfHeight + 1);
    Console.Write("Press the Any key to start");
    Console.ReadKey(true);

    Console.Clear();

    //Draw walls
    for (int i = 0; i < HEIGHT; i++)
    {
        for (int j = 0; j < WIDTH; j++)
        {
            if ((i == 0 || i == HEIGHT - 1) || (j == 0 || j == WIDTH - 1))
            {
                Console.SetCursorPosition(j, i);
                Console.Write(WALL);
            }
        }
    }

    //Draw player
    playerPos = new int[2] { halfWidth, halfHeight };        
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

int[] NewApplePos()
{
    //find empty space for the apple
    int counter = 0;
    do
    {
        int[] tmp = new int[2] { Random.Shared.Next(1, WIDTH - 1), Random.Shared.Next(1, HEIGHT - 1) };
        if (!playerPos.SequenceEqual(tmp) && !tail.Any(t => t.SequenceEqual(tmp))) return tmp;
        else counter++;
    } while (counter <= ((HEIGHT - 1) * (WIDTH - 1)));
    
    //if gameboard full then GameOver
    isGameOver = true;
    return new int[] { 0, 0 };
}

do
{    
    NewGame();

    (int x, int y) moveDir = (1, 0);

    do // GameLoop
    {
        do // UpdateLoop
        {            
            int[] newPos = { playerPos[0] + moveDir.x, playerPos[1] + moveDir.y };

            if (!tail.Any(t => t.SequenceEqual(newPos)) && newPos[0] < WIDTH - 1 && newPos[0] > 0 && newPos[1] < HEIGHT - 1 && newPos[1] > 0)
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

                    //grow tail
                    tailLength++;
                }
            }
            else isGameOver = true;

            Thread.Sleep(moveSpeed);
        }
        while (!Console.KeyAvailable);

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
    while (!isGameOver);

    //Game Over
    Console.SetCursorPosition(halfWidth - 6, halfHeight);
    Console.Write(" Game Over! ");
    Console.SetCursorPosition(halfWidth - 9, halfHeight + 1);
    Console.Write($" Your score was {score}");
    Console.ReadKey(true);
    Console.Clear();

} while (true);