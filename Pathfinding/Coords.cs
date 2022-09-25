namespace Pathfinding
{
    internal class Coords : IEquatable<Coords>
    {
        public int X { get; }
        public int Y { get; }

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coords Left => new(X, Y - 1);
        public Coords Right => new(X, Y + 1);
        public Coords Above => new(X - 1, Y);
        public Coords Below => new(X + 1, Y);

        public override bool Equals(object? obj) => Equals((Coords?)obj);

        public bool Equals(Coords? coord)
        {
            if (coord is null) return false;

            if (ReferenceEquals(this, coord)) return true;

            if (GetType() != coord.GetType()) return false;

            return (X == coord.X) && (Y == coord.Y);
        }
        public override int GetHashCode() => (X, Y).GetHashCode();

        public static bool operator ==(Coords? left, Coords? right)
        {
            if (left is null)
            {
                if (right is null)
                {
                    return true;
                }

                return false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(Coords? left, Coords? right) => !(left == right);
    }
}
