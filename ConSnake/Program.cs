Console.CursorVisible = false;

const int HEIGHT = 15;
const int WIDTH = 50;

const string PLAYER = "O";
const string WALL = "X";
const string APPLE = "@";

int[] playerPos;
int[] applePos;

bool hasMoved;

Queue<int[]> tail;
int tailLength;

int score;

void NewGame()
{
    playerPos = new int[2] { (int)Math.Floor(WIDTH / 2M), (int)Math.Floor(HEIGHT / 2M) };
    applePos = new int[2] { Random.Shared.Next(2, WIDTH - 1), Random.Shared.Next(2, HEIGHT - 1) };

    tail = new();
    tailLength = 0;
    score = 0;
    hasMoved = true;
}


NewGame();

do
{
    if (hasMoved)
    {
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

        //Draw score
        Console.SetCursorPosition(0, 0);
        Console.Write($"Score: {score} ");

        //Draw apple
        Console.SetCursorPosition(applePos[0], applePos[1]);
        Console.Write(APPLE);

        //Draw tail
        foreach (int[] tailPos in tail)
        {
            Console.SetCursorPosition(tailPos[0], tailPos[1]);
            Console.Write(PLAYER);
        }
        if (tail.Count > tailLength) _ = tail.Dequeue();

        //Draw player
        Console.SetCursorPosition(playerPos[0], playerPos[1]);
        Console.Write(PLAYER);
    }
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
    if (x == 0 && y == 0) hasMoved = false;
    else
    {        
        int[] newPos = { playerPos[0] + x, playerPos[1] + y };

        if (!tail.Any(t => t.SequenceEqual(newPos)) && newPos[0] < WIDTH - 1 && newPos[0] > 0 && newPos[1] < HEIGHT - 1 && newPos[1] > 0)
        {
            tail.Enqueue(new int[] { playerPos[0], playerPos[1] });

            playerPos = newPos;

            if (applePos.SequenceEqual(playerPos))
            {
                applePos = new int[2] { Random.Shared.Next(2, WIDTH - 1), Random.Shared.Next(2, HEIGHT - 1) };

                tailLength++;
                score++;
            }

            hasMoved = true;
        }
        else hasMoved = false;
    }

} while (true);