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

            _map[0, 2].IsWall = true;
            _map[1, 2].IsWall = true;
            _map[2, 2].IsWall = true;
            _map[3, 2].IsWall = true;

            _map[5, 0].IsWall = true;
            _map[5, 1].IsWall = true;
            _map[5, 2].IsWall = true;
            _map[5, 3].IsWall = true;
            _map[5, 4].IsWall = true;

            _map[2, 4].IsWall = true;
            _map[3, 4].IsWall = true;
            _map[4, 4].IsWall = true;
            _map[2, 5].IsWall = true;
            _map[2, 6].IsWall = true;
            _map[2, 7].IsWall = true;

            _map[4, 6].IsWall = true;
            _map[4, 7].IsWall = true;
            
            _map[12, 8].IsWall = true;
            _map[12, 7].IsWall = true;
            _map[12, 6].IsWall = true;
            _map[12, 4].IsWall = true;
            _map[12, 3].IsWall = true;
            _map[12, 2].IsWall = true;
            _map[12, 1].IsWall = true;

            _map[11, 6].IsWall = true;
            _map[10, 6].IsWall = true;
            _map[10, 5].IsWall = true;
            _map[10, 4].IsWall = true;

            _map[3, 7].IsWall = true;
            _map[6, 7].IsWall = true;
            _map[6, 8].IsWall = true;
            _map[6, 9].IsWall = true;

            _map[6, 5].IsWall = true;            
            _map[6, 4].IsWall = true;
            
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

        private Node? FindNode(int x, int y) => FindNode(new(x, y));
        private Node? FindNode(Coords coord)
        {
            if (coord.X >= 0 && coord.X < _map.GetLength(COL) && coord.Y >= 0 && coord.Y < _map.GetLength(ROW)) return _map[coord.X, coord.Y];
            else return null;
        }

        public List<Node> FindPath(Coords start, Coords end)
        {
            Node? startNode = FindNode(start);
            if (startNode == null) throw new ArgumentOutOfRangeException("Start", "Start position out of map scope");

            Node? endNode = FindNode(end);
            if (endNode == null) throw new ArgumentOutOfRangeException("End", "End position out of map scope");

            List<Node> eval = new() { endNode };

            int index = 0;
            do
            {
                List<Node> neighbours = FindNeighbours(eval[index]);
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

            if (eval.Count == 1) return new List<Node> { eval[0] };
            else
            {
                List<Node> path = new() { startNode };              

                for (int i = startNode.Counter; i >= 0; i--)
                {
                    Node currentNode = path.Last();

                    List<Node> possible = new();

                    Node? right = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Right, null);
                    if (right != null) possible.Add(right);

                    Node? below = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Below, null);
                    if (below != null) possible.Add(below);

                    Node? left = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Left, null);
                    if (left != null) possible.Add(left);

                    Node? above = eval.FirstOrDefault(x => x?.Coord == currentNode.Coord.Above, null);
                    if (above != null) possible.Add(above);

                    possible.Sort();

                    path.Add(possible.First());               

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
                }
                return path;
            }
        }
       
        private List<Node> FindNeighbours(Node node)
        {
            List<Node> neighbours = new();

            Node? left = FindNode(node.Coord.Left);
            if (left != null)
            {
                left.Counter = node.Counter + 1;
                neighbours.Add(left);
            }

            Node? right = FindNode(node.Coord.Right);
            if (right != null)
            {
                right.Counter = node.Counter + 1;
                neighbours.Add(right);
            }

            Node? above = FindNode(node.Coord.Above);
            if (above != null)
            {
                above.Counter = node.Counter + 1;
                neighbours.Add(above);
            }

            Node? belove = FindNode(node.Coord.Below);
            if (belove != null)
            {
                belove.Counter = node.Counter + 1;
                neighbours.Add(belove);
            }

            return neighbours;
        }
    }
}
