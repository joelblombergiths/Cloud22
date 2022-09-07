
//void PrintGreetingMultipleTimes(string name) => PrintGreetingMultipleTimes(name, 1);

internal class Program
{
    private static void Main(string[] args)
    {

        PrintGreetingMultipleTimes("Kalle");
        PrintGreetingMultipleTimes("Adam", 2);
        PrintGreetingMultipleTimes("David", 3, true);
    }

    static void PrintGreetingMultipleTimes(string name) => PrintGreetingMultipleTimes(name, 1, false);
    static void PrintGreetingMultipleTimes(string name, int numberTimes) => PrintGreetingMultipleTimes(name, numberTimes, false);
    static void PrintGreetingMultipleTimes(string name, bool exclaim) => PrintGreetingMultipleTimes(name, 1, exclaim);
    static void PrintGreetingMultipleTimes(string name, int numberTimes, bool exclaim)
    {
        for (int i = 0; i < numberTimes; i++)
        {
            Console.WriteLine($"Hello, {name}{(exclaim ? "!!!" : string.Empty)}");
        }
    }
}