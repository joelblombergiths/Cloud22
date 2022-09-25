namespace Pathfinding
{
    internal class Node : IComparable<Node>
    {
        public Coords Coord { get; }

        public bool IsWall { get; set; }
        public int Cost { get; set; }

        public Node(Coords coord)
        {
            Coord = coord;
            IsWall = false;
            Cost = -1;
        }

        public override bool Equals(object? obj) => Equals((Node?)obj);
        public bool Equals(Node? node)
        {
            if (node is null) return false;
                        
            return Coord == node.Coord;
        }

        public static bool operator ==(Node? left, Node? right)
        {
            if (left is null)
            {
                if (right is null) return true;
                
                return false;
            }
            
            return left.Equals(right);
        }

        public static bool operator !=(Node? left, Node? right) => !(left == right);

        public override int GetHashCode() => (Coord, IsWall, Cost).GetHashCode();

        public int CompareTo(Node? other)
        {
            if (other == null) return 1;

            return Cost.CompareTo(other?.Cost);
        }
    }
}
