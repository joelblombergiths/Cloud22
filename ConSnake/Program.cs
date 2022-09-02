Console.CursorVisible = false;

const int HEIGHT = 15;
const int WIDTH = 50;

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

bool isGameOver;

void NewGame()
{
    isGameOver = false;
    tail = new();
    tailLength = 0;

    Console.Clear();

    //Draw walls
    for (int i = 0; i < HEIGHT; i++)
    {
        for (int j = 0; j < WIDTH; j++)
        {
            Console.SetCursorPosition(j, i);
            if ((i == 0 || i == HEIGHT - 1) || (j == 0 || j == WIDTH - 1)) Console.Write(WALL);
        }
    }

    //Draw player
    playerPos = new int[2] { (int)Math.Floor(WIDTH / 2M), (int)Math.Floor(HEIGHT / 2M) };    
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
    do
    {
        int[] tmp = new int[2] { Random.Shared.Next(2, WIDTH - 1), Random.Shared.Next(2, HEIGHT - 1) };
        if (!playerPos.SequenceEqual(tmp) && !tail.Any(t => t.SequenceEqual(tmp))) return tmp;
    } while (true);
}

do
{
    Console.SetCursorPosition(((int)Math.Floor(WIDTH / 2M)) -4, (int)Math.Floor(HEIGHT / 2M));
    Console.Write("ConSnake");
    Console.SetCursorPosition(((int)Math.Floor(WIDTH / 2M)) - 14, ((int)Math.Floor(HEIGHT / 2M)) + 1);
    Console.Write("Press the Any key to start");
    Console.ReadKey(false);
    NewGame();

    do
    {
        //fetch input
        (int x, int y) = Console.ReadKey(true).Key switch
        {
            ConsoleKey.LeftArrow => (-1, 0),
            ConsoleKey.RightArrow => (1, 0),
            ConsoleKey.UpArrow => (0, -1),
            ConsoleKey.DownArrow => (0, 1),
            _ => (0, 0)
        };

        //check valid move
        if (x == 0 ^ y == 0)
        {
            int[] newPos = { playerPos[0] + x, playerPos[1] + y };

            if (!tail.Any(t => t.SequenceEqual(newPos)) && newPos[0] < WIDTH - 1 && newPos[0] > 0 && newPos[1] < HEIGHT - 1 && newPos[1] > 0)
            {
                //Update tail           
                tail.Enqueue(new int[] { playerPos[0], playerPos[1] });
                foreach (int[] tailPos in tail)
                {
                    Console.SetCursorPosition(tailPos[0], tailPos[1]);
                    Console.Write(TAIL);
                }

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
        }

    } while (!isGameOver);

    Console.SetCursorPosition(((int)Math.Floor(WIDTH / 2M)) - 5, (int)Math.Floor(HEIGHT / 2M));
    Console.Write("Game Over!");
    Console.ReadKey(false);
    Console.Clear();

} while (true);