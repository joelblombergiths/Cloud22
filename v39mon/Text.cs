namespace v39mon;

internal class Text
{
    private static readonly char[] vowels = new char[] {'a','o','u','e','i','y' };

    private static readonly List<Text> _instances = new();

    public static int TotalLengthOfAllInstances => _instances.Sum(x => x.Value.Length);
    public static double AverageLengthOfAllInstances => _instances.Average(x => x.Value.Length);

    public string Value { get; set; }

    public int Vowels => Value.Count(x => vowels.Contains(x));
    public int Consonants => Value.Count(x => char.IsLetter(x) && !vowels.Contains(x));

    private Text(string s)
    {
        Value = s;
    }

    public static Text Create(string s)
    {
        Text t = new(s);

        _instances.Add(t);

        return t;
    }
}
