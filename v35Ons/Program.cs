void uppg1()
{
    Console.WriteLine("Input first number: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int secondNumber = int.Parse(Console.ReadLine());

    int sum = firstNumber * secondNumber;

    Console.WriteLine($"{firstNumber} * {secondNumber} = {sum}");
}

void uppg2()
{
    Console.WriteLine("Input first name: ");
    string firstName = Console.ReadLine();

    Console.WriteLine("Input last name: ");
    string lastName = Console.ReadLine();

    Console.WriteLine($"Your name is {firstName} {lastName}");
}

void uppg3()
{
    string myName = "Joel";

    Console.WriteLine("Input first name: ");
    string firstName = Console.ReadLine();

    bool isMyName = firstName.Equals(myName);

    if (isMyName) Console.WriteLine($"Hello {firstName}, your are the one i'm thinking of!");
    else Console.WriteLine("Who are you?");
}

void uppg4()
{
    Console.WriteLine("Input number: ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine($"Double: {number * 2}");
    Console.WriteLine($"Half: {number / 2f}");
}

uppg4();