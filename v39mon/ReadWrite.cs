namespace v39mon;

internal static class ReadWrite
{
    private static string _value = string.Empty;
    public static string Write { set => _value = value; }
    public static string Read { get => _value; }
}
