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

    Console.WriteLine($"Double of {number} is {number * 2}");
    Console.WriteLine($"Halfof {number} is {number / 2f}");
}


void uppg5()
{
    for (int i = 20; i <= 30; i++)
    {
        Console.WriteLine(i);
    }
}

void uppg6()
{
    for (int i = 0; i <= 30; i += 2)
    {
        Console.WriteLine(i);
    }
}

void uppg7()
{
    for (int i = 0; i <= 30; i++)
    {
        if (i % 3 == 0) Console.WriteLine("Hej!");
        else Console.WriteLine(i);
    }
}

void uppg8()
{
    Console.WriteLine("Show multiplication table for: ");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(number * i);
    }
}

void uppg9()
{
    Console.WriteLine("Input width: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine("Input height: ");
    int height = int.Parse(Console.ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("X");
        }
        Console.WriteLine();
    }
}

void uppg10()
{
    Console.WriteLine("Input width: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine("Input height: ");
    int height = int.Parse(Console.ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write(j % 2 == 0 ? "X" : "O");
        }
        Console.WriteLine();
    }
}

void uppg11()
{
    Console.WriteLine("Input width: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine("Input height: ");
    int height = int.Parse(Console.ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write((i + j) % 2 == 0 ? "X" : "O");
        }
        Console.WriteLine();
    }
}

void uppg12()
{
    Console.WriteLine("Input width: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine("Input height: ");
    int height = int.Parse(Console.ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == height - 1) Console.Write("X");
            else if (j == 0 || j == width - 1) Console.Write("X");            
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void uppg13()
{
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}

void uppg14()
{
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            for (int k = 1; k <= j; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }
}

void uppg15()
{
    int secret = Random.Shared.Next(1, 100);
    int numGuesses = 0;
    bool isGameOver = false;

    do
    {
        int currentGuess;
        bool isValidGuess;

        do
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            isValidGuess = int.TryParse(Console.ReadLine(), out currentGuess);
            if (!isValidGuess) Console.WriteLine("Not a valid guess!");
        } while (!isValidGuess);

        numGuesses++;

        if (currentGuess == secret)
        {
            Console.WriteLine("That is Correct!!");
            isGameOver = true;
        }
        else if(currentGuess > secret) Console.WriteLine("That's a little too high");
        else Console.WriteLine("That's a little too low");

    } while (!isGameOver);

    Console.WriteLine($"You found the number on {numGuesses} tries, good job!");
}


while (true)
{
    uppg12();
    Console.ReadKey();
}