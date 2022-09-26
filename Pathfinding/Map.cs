namespace Pathfinding
{
    internal class Map
    {
        private const int COL = 0;
        private const int ROW = 1;

        private readonly int _width;
        private readonly int _height;

        private readonly Node[,] _map;

        public Map(int width, int height)
        {
            _width = width;
            _height = height;

            _map = new Node[_width, _height];

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Node n = new(new(x, y));

                    if (y == 0 || y == _height - 1 || x == 0 || x == _width - 1) n.IsWall = true;

                    _map[x, y] = n;
                }
            }
        }

        public Node this[int x, int y]
        {
            get
            {
                Node? n = FindNode(x, y);
                if (n != null) return n;
                else throw new ArgumentOutOfRangeException("Position out of map scope");
            }
        }

        private Node? FindNode(Coords coord) => FindNode(coord.X, coord.Y);
        private Node? FindNode(int x, int y)
        {
            if (x >= 0 && x < _map.GetLength(COL) && y >= 0 && y < _map.GetLength(ROW)) return _map[x, y];
            else return null;
        }

        public List<Node> FindPath(Coords start, Coords end)
        {
            Node? startNode = FindNode(start);
            if (startNode == null) throw new ArgumentOutOfRangeException("Start", "Start position out of map scope");

            Node? endNode = FindNode(end);
            if (endNode == null) throw new ArgumentOutOfRangeException("End", "End position out of map scope");

            List<Node> neighbours = EvaluateNeighbours(endNode);

            List<Node> shortestPath = FindShortestPath(startNode, neighbours);

            return shortestPath;
        }

        private List<Node> EvaluateNeighbours(Node endNode)
        {
            List<Node> eval = new() { endNode };

            int index = 0;
            do
            {
                Node currentNode = eval[index];
                List<Node> neighbours = FindNeighbour(currentNode);

                foreach (Node node in neighbours)
                {
                    if (!node.IsWall)
                    {
                        if (!eval.Contains(node)) eval.Add(node);
                    }
                }
                index++;
            }
            while (index < eval.Count);

            return eval;
        }
       
        private List<Node> FindNeighbour(Node node)
        {
            List<Node> neighbours = new();

            Node? left = FindNode(node.Coord.Left);
            if (left != null)
            {
                left.Cost = node.Cost + 1;
                neighbours.Add(left);
            }

            Node? right = FindNode(node.Coord.Right);
            if (right != null)
            {
                right.Cost = node.Cost + 1;
                neighbours.Add(right);
            }

            Node? above = FindNode(node.Coord.Above);
            if (above != null)
            {
                above.Cost = node.Cost + 1;
                neighbours.Add(above);
            }

            Node? belove = FindNode(node.Coord.Below);
            if (belove != null)
            {
                belove.Cost = node.Cost + 1;
                neighbours.Add(belove);
            }

            return neighbours;
        }

        private static List<Node> FindShortestPath(Node startNode, List<Node> neighbours)
        {
            if (neighbours.Count == 1) return new List<Node> { neighbours[0] };
            else
            {
                List<Node> path = new() { startNode };

                for (int i = startNode.Cost; i >= 0; i--)
                {
                    Node currentNode = path.Last();

                    List<Node> possible = new();

                    Node? right = neighbours.FirstOrDefault(x => x?.Coord == currentNode.Coord.Right, null);
                    if (right != null) possible.Add(right);

                    Node? below = neighbours.FirstOrDefault(x => x?.Coord == currentNode.Coord.Below, null);
                    if (below != null) possible.Add(below);

                    Node? left = neighbours.FirstOrDefault(x => x?.Coord == currentNode.Coord.Left, null);
                    if (left != null) possible.Add(left);

                    Node? above = neighbours.FirstOrDefault(x => x?.Coord == currentNode.Coord.Above, null);
                    if (above != null) possible.Add(above);

                    possible.Sort();

                    path.Add(possible.First());
                }
                return path;
            }
        }
    }
}

//Node? right = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Right, null);
//if (right?.Counter == i + 1)
//{
//    path.Add(right);
//    continue;
//}

//Node? below = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Below, null);
//if (below?.Counter == i + 1)
//{
//    path.Add(below);
//    continue;
//}

//Node? left = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Left, null);
//if (left?.Counter == i + 1)
//{
//    path.Add(left);
//    continue;
//}

//Node? above = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Above, null);
//if (above?.Counter == i + 1)
//{
//    path.Add(above);
//    continue;
//}