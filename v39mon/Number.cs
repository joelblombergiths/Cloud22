namespace v39mon;

internal class Number
{
    private readonly List<int> _history = new();
    public int[] GetHistory => _history.ToArray();

    private int _value;
    public int Value
    {
        get => _value;
        set
        {
            _history.Add(_value);
            _value = value;
        }
    }

    //public static implicit operator Number(int n) => new (n);

    //public static implicit operator int(Number n) => n._value;

    public Number() : this(0) { }
    public Number(int value)
    {
        _history = new();
        Value = value;
    }
}
