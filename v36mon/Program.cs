#pragma warning disable IDE0062 // Make local function 'static'
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8321 // Local function is declared but never used
#pragma warning disable CS8601 // Possible null reference assignment.

using System.Numerics;

void uppg41()
{
    Console.WriteLine("Input first number: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int secondNumber = int.Parse(Console.ReadLine());

    Console.WriteLine($"The largest is {Math.Max(firstNumber, secondNumber)}");
}

void uppg42()
{
    Console.WriteLine("Input weight (kg): ");
    int weight = int.Parse(Console.ReadLine());

    Console.WriteLine("Input length (m): ");
    double length = double.Parse(Console.ReadLine());

    double bmi = Math.Round(weight / Math.Pow(length, 2), 2);

    Console.WriteLine($"BMI: {bmi}");
}

void uppg43()
{
    Console.WriteLine("Input number of bits: ");
    int n = int.Parse(Console.ReadLine());
    BigInteger max = (BigInteger)Math.Pow(2, n - 1);

    Console.WriteLine($"maximum capacity: {max}");
}


void uppg44()
{
    Console.WriteLine("Input length of rectangle: ");
    int length = int.Parse(Console.ReadLine());

    Console.WriteLine("Input width of rectangle: ");
    int width = int.Parse(Console.ReadLine());

    double h = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
    Console.WriteLine($"Hypotenuse: {Math.Round(h, 2)}");
}

void uppg45()
{
    int value = 5;
    do
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(value);

        int change = Console.ReadKey().Key switch
        {
            ConsoleKey.UpArrow => 1,
            ConsoleKey.DownArrow => -1,
            _ => 0
        };

        value = Math.Clamp(value + change, 0, 9);
    }
    while (true);
}

void uppg46()
{
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine($"Hej {name.Trim()}");
}

void uppg47()
{
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    string[] fullName = name.Split(' ');
    Console.WriteLine($"First Name: {fullName[0].Trim()}");
    Console.WriteLine($"Last Name: {fullName[1].Trim()}");
}

void uppg48()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    string[] words = text.Split(' ');
    words = words.Reverse().ToArray();
    words[0] = char.ToUpper(words[0][0]) + words[0][1..];
    Console.WriteLine(string.Join(" ", words));
}

void uppg49()
{
    Console.WriteLine("Enter equation: ");
    string eq = Console.ReadLine();

    string[] parts = eq.Split(' ');

    decimal firstNumber = decimal.Parse(parts[0]);
    char operatorChar = parts[1][0];
    decimal secondNumber = decimal.Parse(parts[2]);

    decimal sum = operatorChar switch
    {
        '+' => firstNumber + secondNumber,
        '-' => firstNumber - secondNumber,
        '/' => firstNumber / secondNumber,
        '*' => firstNumber * secondNumber,
        _ => 0
    };

    Console.WriteLine($"{firstNumber} {operatorChar} {secondNumber} = {sum}");
}

void uppg49_2()
{
    Console.WriteLine("Enter equation: ");
    string eq = Console.ReadLine();

    char operatorChar = '\0';

    if(eq.IndexOf('+') > 0) operatorChar = '+';
    else if (eq.IndexOf('-') > 0) operatorChar = '-';
    else if (eq.IndexOf('*') > 0) operatorChar = '*';
    else if (eq.IndexOf('/') > 0) operatorChar = '/';
    
    string[] parts = eq.Split(operatorChar);

    decimal firstNumber = decimal.Parse(parts[0]);    
    decimal secondNumber = decimal.Parse(parts[1]);

    decimal sum = operatorChar switch
    {
        '+' => firstNumber + secondNumber,
        '-' => firstNumber - secondNumber,
        '/' => firstNumber / secondNumber,
        '*' => firstNumber * secondNumber,
        _ => 0
    };

    Console.WriteLine($"{firstNumber} {operatorChar} {secondNumber} = {sum}");
}

void uppg50()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    Console.WriteLine(text.Replace(" ", "_"));
}

void uppg51()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    string[] words = text.Split(' ');
    words = words.Select(x => char.ToUpper(x[0]) + x[1..]).ToArray();

    Console.WriteLine(string.Join(" ", words));
}

void uppg52()
{
    int[] numbers = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Enter number #{i + 1}: ");

        numbers[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    Array.Sort(numbers);

    foreach (int number in numbers)
    {
        Console.WriteLine($"{number,3}");
    }
}

void uppg53()
{
    Console.WriteLine("Enter 10 numbers separated by comma");
    string input = Console.ReadLine();
    int[] numbers = input.Split(',').Select(x => int.Parse(x)).ToArray();

    Array.Sort(numbers);
    
    foreach (int number in numbers)
    {
        Console.WriteLine($"{number,2}");
    }
}

while (true)
{
    uppg49_2();
    Console.ReadKey();
    Console.Clear();
}