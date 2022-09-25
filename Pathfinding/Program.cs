using Pathfinding;

Console.CursorVisible = false;

const int HEIGHT = 10;
const int WIDTH = 15;

Coords start = new(1, 1);
Coords end = new(13, 8);

Map map = new(WIDTH, HEIGHT);

map[0, 2].IsWall = true;
map[1, 2].IsWall = true;
map[2, 2].IsWall = true;
map[3, 2].IsWall = true;

map[5, 0].IsWall = true;
map[5, 1].IsWall = true;
map[5, 2].IsWall = true;
map[5, 3].IsWall = true;
map[5, 4].IsWall = true;

map[2, 4].IsWall = true;
map[3, 4].IsWall = true;
map[4, 4].IsWall = true;
map[2, 5].IsWall = true;
map[2, 6].IsWall = true;
map[2, 7].IsWall = true;

map[4, 6].IsWall = true;
map[4, 7].IsWall = true;

map[12, 8].IsWall = true;
map[12, 7].IsWall = true;
map[12, 6].IsWall = true;
map[12, 4].IsWall = true;
map[12, 3].IsWall = true;
map[12, 2].IsWall = true;
map[12, 1].IsWall = true;

map[11, 6].IsWall = true;
map[10, 6].IsWall = true;
map[10, 5].IsWall = true;
map[10, 4].IsWall = true;

map[3, 7].IsWall = true;
map[6, 7].IsWall = true;
map[6, 8].IsWall = true;
map[6, 9].IsWall = true;

map[6, 5].IsWall = true;
map[6, 4].IsWall = true;

do
{
    DrawMap(map);
    Console.ReadKey(true);

    List<Node> path = map.FindPath(start, end);
    DrawPath(path);
    Console.ReadKey(true);
}
while (true);

void DrawMap(Map map)
{
    Console.Clear();
    for (int y = 0; y < HEIGHT; y++)
    {
        Console.SetCursorPosition(0, y);

        for (int x = 0; x < WIDTH; x++)
        {
            Node n = map[x, y];

            if (n.Coord == start)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("S");
            }
            else if (n.Coord == end)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("E");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(n.IsWall ? "X" : ".");
            }      
        }

        Console.WriteLine();
    }
}


void DrawPath(List<Node> path)
{
    Console.ForegroundColor = ConsoleColor.Red;
    
    foreach (Node node in path)
    {
        Console.SetCursorPosition(node.Coord.X, node.Coord.Y);        
        Console.Write("#");

        Thread.Sleep(150);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}

/*
    for (int y = 0; y < HEIGHT; y++)
    {
        Console.SetCursorPosition(0, y);

        for (int x = 0; x < WIDTH; x++)
        {
            Node n = map[x, y];

            if (path.Contains(n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (n.Coord == start) Console.Write("S".PadRight(2, ' ').PadLeft(2, ' '));
                else if (n.Coord == end) Console.Write("E".PadRight(2, ' ').PadLeft(2, ' '));
                else Console.Write(n.IsWall ? "X".PadRight(2, ' ').PadLeft(2, ' ') : n.Counter < 0 ? ".".PadRight(2, ' ').PadLeft(2, ' ') : n.Counter.ToString().PadRight(2, ' ').PadLeft(2, ' '));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(n.IsWall ? "X".PadRight(2, ' ').PadLeft(2, ' ') : ".".PadRight(2, ' ').PadLeft(2, ' '));
            }
        }

        Console.WriteLine();
    }
 */