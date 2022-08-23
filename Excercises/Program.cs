

#pragma warning disable CS8321 // Local function is declared but never used
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

static void ex1()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Joel Blomberg");
}

static void ex2()
{
    Console.WriteLine(6 + 2);
}

static void ex3()
{
    Console.WriteLine(6 / 2);
}

static void ex4()
{
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine((35 + 5) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
}

static void ex5()
{
    Console.WriteLine("Input first number: ");

    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int tmp = n1;
    n1 = n2;
    n2 = tmp;
    Console.WriteLine($"First number: {n1}");
    Console.WriteLine($"Seccond number: {n2}");
}

static void ex6()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} * {n2} * {n3} = {n1 * n2 * n3}");

}

static void ex7()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
    Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");
}

static void ex8()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 1; i <=10; i++)
    {
        Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

static void ex9()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input fourth number: ");
    int n4 = int.Parse(Console.ReadLine());

    int avg = (n1 + n2 + n3 + n4) / 4;

    Console.WriteLine($"Average of {n1},{n2},{n3},{n4} is {avg}");
}

static void ex10()
{
    //(x+y).z and x.y + y.z. 
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"({n1}+{n2})*{n3} = {(n1 + n2) * n3} and {n1}*{n2}+{n1}*{n3} = {n1 * n2 + n1 * n3}");
}

static void ex11()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"You look older than {n}");
}

static void ex12()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();

        for (int y = 0; y < 4; y++)
        {
            Console.Write(n);
        }
        Console.WriteLine();
    }
}

static void ex13()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    int numRows = 5;

    for (int row = 0; row < numRows; row++)
    {
        switch (row)
        {
            case 0:
            case int _ when row == numRows -1: Console.WriteLine($"{n}{n}{n}"); break;
            default: Console.WriteLine($"{n} {n}"); break;
        }
    }
}

static void ex14()
{
    Console.WriteLine("Input degrees in Celsius: ");
    int celsius = int.Parse(Console.ReadLine());

    float farenheit = (celsius * 9 / 5) + 32;
    float kelvin = celsius + 273.15f;

    Console.WriteLine($"{celsius}°C is:");
    Console.WriteLine($"{farenheit}°F");
    Console.WriteLine($"{kelvin}°K");
}

static void ex15()
{
    string org = "w3resource";
    Console.WriteLine($"Original string \"{org}\"");
    Console.WriteLine($"index 1 removed: {org.Remove(1, 1)}");
    Console.WriteLine($"index 9 removed: {org.Remove(9, 1)}");
    Console.WriteLine($"index 0 removed: {org.Remove(0, 1)}");
}

static void ex16()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();


    string newText = text.Length > 1 ? $"{text[^1]}{text[1..^1]}{text[0]}" : text;
    Console.WriteLine($"New text: {newText}");
}

static void ex17()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string? newText = !string.IsNullOrEmpty(text) ? $"{text[0]}{text}{text[0]}" : text;
    Console.WriteLine($"New text: {newText}");
}

static void ex18()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match;
    if ((n1 >= 0 && n2 < 0) || (n2 >= 0 && n1 < 0)) match = true;
    else match = false;

    Console.WriteLine(match);
}

static void ex19()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    if (n1 == n2) sum *= 3;

    Console.WriteLine(sum);
}

static void ex20()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int value = Math.Abs(n1 - n2);
    if (n1 > n2) value *= 2;

    Console.WriteLine(value);
}

static void ex21()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    bool match;

    if (sum == 20 || n1 == 20 || n2 == 20) match = true;
    else match = false;

    Console.WriteLine(match);
}

static void ex22()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match;
    if (Math.Abs(100 - n) <= 20 || Math.Abs(200 - n) <= 20) match = true;
    else match = false;

    Console.WriteLine(match);
}

static void ex23()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine($"Lowercase: {text.ToLower()}");
}

static void ex24()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string[] words = text.Split(' ');

    Console.WriteLine($"Longest word is: {words.OrderBy(x => x.Length).Last()}");
}

static void ex25()
{
    for(int i = 0; i < 100; i++)
    {
        if (i % 2 != 0) Console.WriteLine(i);
    }
}

static void ex26()
{
    List<int> primeNumbers = new List<int>();

    int counter = 2;
    do
    {
        bool match = true;        
        for (int i = 2; i < counter; i++)
        {
            if (counter % i == 0)
            {
                match = false; 
                break;
            }
        }
        if (match) primeNumbers.Add(counter);
        
        counter++;
    }
    while (primeNumbers.Count < 500);
    Console.WriteLine(string.Join("\n",primeNumbers));
    Console.WriteLine($"Sum of first 500 prime numbers: {primeNumbers.Sum()}");
}

static void ex27()
{
    Console.WriteLine("Input number: ");
    string text = Console.ReadLine();

    int sum = text.ToArray().Select(x => int.Parse(x.ToString())).Sum();
    Console.WriteLine($"The sum of the digits in {text} is {sum}");
}

