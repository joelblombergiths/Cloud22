#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8321 // Local function is declared but never used


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
            //if (i == 0 || i == height - 1) Console.Write("X");
            //else if (j == 0 || j == width - 1) Console.Write("X");            
            //else Console.Write(" ");

            Console.Write((i == 0 || i == height - 1) || (j == 0 || j == width - 1) ? "X" : " ");
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
        Console.WriteLine();
    }
}

void uppg15()
{
    const int MAX = 100;
    int secret = Random.Shared.Next(1, MAX + 1);
    int numGuesses = 0;
    bool isGameOver = false;

    do
    {
        int currentGuess;
        bool isValidGuess;

        do
        {
            Console.WriteLine($"Enter a number between 1 and {MAX}: ");
            isValidGuess = int.TryParse(Console.ReadLine(), out currentGuess);
            if (!isValidGuess) Console.WriteLine("Not a valid guess!");
        } while (!isValidGuess);

        numGuesses++;

        if (currentGuess == secret)
        {
            Console.WriteLine("That is Correct!!");
            isGameOver = true;
        }
        else if (currentGuess > secret) Console.WriteLine("That's a little too high");
        else Console.WriteLine("That's a little too low");

    } while (!isGameOver);

    Console.WriteLine($"You found the number on {numGuesses} tries, good job!");
}

void uppg15_2()
{
    const int MAX = 100;
    int secret = Random.Shared.Next(1, MAX + 1);

    int numGuesses = 0;
    bool isGameOver = false;

    int lowGuess = 0;
    int highGuess = MAX;

    do
    {
        int currentGuess = (lowGuess + highGuess) / 2;

        Console.Write($"Enter a number between 1 and {MAX}: ");
        Thread.Sleep(200);
        Console.WriteLine(currentGuess);

        numGuesses++;

        if (currentGuess == secret)
        {
            Console.WriteLine("That is Correct!!");
            isGameOver = true;
        }
        else if (currentGuess > secret)
        {
            Console.WriteLine("That's a little too high");
            highGuess = currentGuess;
        }
        else
        {
            Console.WriteLine("That's a little too low");
            lowGuess = currentGuess;
        }

        Thread.Sleep(100);
    } while (!isGameOver);

    Console.WriteLine($"You found the number on {numGuesses} tries, good job!");
}

void uppg16()
{
    int sum = 0;
    for (int i = 1; i <= 100; i++)
    {
        sum += i;
    }

    Console.WriteLine(sum);
}

void uppg17()
{
    List<int> primeNumbers = new();

    int counter = 2;
    bool match;

    do
    {
        match = true;
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
    while (primeNumbers.Count < 20);

    Console.WriteLine(string.Join("\n", primeNumbers));
}

void uppg18()
{
    ulong a = 0;
    ulong b = 1;
    ulong fib;

    Console.WriteLine($"1: {a}");
    Console.WriteLine($"2: {b}");

    for (int i = 3; i <= 100; i++)
    {
        fib = a + b;
        a = b;
        b = fib;
        Console.WriteLine($"{i}: {fib}");
    }
}

void uppg19()
{
    List<int> numbers = new();
    bool isNumber;
    int inputNumber;

    do
    {
        Console.WriteLine($"Enter a number: ");
        isNumber = int.TryParse(Console.ReadLine(), out inputNumber);
        if (isNumber)
        {
            numbers.Add(inputNumber);
            Console.WriteLine($"Current sum is: {numbers.Sum()}");
        }
    } while (isNumber);

    Console.WriteLine($"Average of the {numbers.Count} numbers entered is {numbers.Average()}");
}

void uppg20()
{
    decimal firstNumber = RequestNumber();
    char operatorChar = RequestOperator();
    decimal secondNumber = RequestNumber();

    decimal sum = operatorChar switch
    {
        '+' => firstNumber + secondNumber,
        '-' => firstNumber - secondNumber,
        '/' => firstNumber / secondNumber,
        '*' => firstNumber * secondNumber,
        _ => 0
    };

    Console.WriteLine($"{firstNumber} {operatorChar} {secondNumber} = {sum}");

    decimal RequestNumber()
    {
        decimal inputNumber;
        bool isValidInput;
        do
        {
            Console.WriteLine($"Enter a number: ");
            isValidInput = decimal.TryParse(Console.ReadLine(), out inputNumber);
            if (!isValidInput) Console.WriteLine("Invalid Input");
        } while (!isValidInput);

        return inputNumber;
    }

    char RequestOperator()
    {
        char[] operators = { '+', '-', '/', '*' };

        char op;
        bool isValidInput;
        do
        {
            Console.WriteLine("Enter operator: ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            isValidInput = operators.Contains(op);
            if (!isValidInput) Console.WriteLine($"valid operators are {string.Join(",", operators)}");
        } while (!isValidInput);

        return op;
    }
}

void uppg21()
{
    int number = 1;
    for (int i = 0; i < 16; i++)
    {
        number *= 2;
        Console.WriteLine(number);
    }
}

void uppg22()
{
    const int ROCK = 0;
    const int PAPER = 1;
    const int SCISSORS = 2;
    const int LIZARD = 3;
    const int SPOCK = 4;
    string[] choices = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

    bool isGameOver = false;
    int playerScore = 0;
    int computerScore = 0;

    do
    {
        if (!RequestPlayerChoice(out string playerChoice)) isGameOver = true;

        if (!isGameOver)
        {
            Console.WriteLine($"Player chose {playerChoice}");

            string computerChoice = choices.GetValue(Random.Shared.Next(0, choices.Length)).ToString();
            Console.WriteLine($"Computer chose {computerChoice}");

            if (playerChoice == computerChoice) Console.WriteLine("It's a Tie!");
            else
            {
                if (CheckResult(playerChoice, computerChoice))
                {
                    Console.WriteLine("Player won this round");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Computer won this round");
                    computerScore++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press the Any key to start the next round");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine($"Player got {playerScore} points");
            Console.WriteLine($"Computer got {computerScore} points");
        }
    } while (!isGameOver);

    bool RequestPlayerChoice(out string choice)
    {
        choice = string.Empty;
        bool isValidInput;

        do
        {
            Console.WriteLine($"Enter {string.Join(" or ", choices)}: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return false;
            else
            {
                choice = choices.FirstOrDefault(x => x.StartsWith(input, StringComparison.OrdinalIgnoreCase), string.Empty);

                isValidInput = !string.IsNullOrEmpty(choice);
            }

            if (!isValidInput) Console.WriteLine($"valid choices are {string.Join(",", choices)}");
        } while (!isValidInput);

        Console.Clear();
        return true;
    }

    bool CheckResult(string player, string computer)
    {
        List<string> selectedChoices = new() { player, computer };

        List<(string WinningChoice, string LoosingChoice, string Reason)> combinations = new()
        {
            (choices[SCISSORS], choices[PAPER], "Scissors cuts Paper"),
            (choices[PAPER], choices[ROCK], "Paper covers Rock"),
            (choices[ROCK], choices[LIZARD], "Rock crushes Lizard"),
            (choices[LIZARD], choices[SPOCK], "Lizard poisons Spock"),
            (choices[SPOCK], choices[SCISSORS], "Spock smashes Scissors"),
            (choices[SCISSORS], choices[LIZARD], "Scissors decapitates Lizard"),
            (choices[LIZARD], choices[PAPER], "Lizard eats Paper"),
            (choices[PAPER], choices[SPOCK], "Paper disproves Spock"),
            (choices[SPOCK], choices[ROCK], "Spock vaporizes Rock"),
            (choices[ROCK], choices[SCISSORS], "Rock crushes Scissors")
        };

        (string WinningChoice, string LoosingChoice, string Reason) = combinations.Find(x => selectedChoices.Contains(x.WinningChoice) && selectedChoices.Contains(x.LoosingChoice));
        Console.WriteLine(Reason);

        return player == WinningChoice;
    }
}

void uppg23()
{
    string[] possibleChars = { "-", "#", "o", "w", "~" };
    int[,] a = new[,] { { 1, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0, 0 } };
    int[,] b = new[,] { { 1, 0, 0, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0, 0, 0, 1 } };
    int[,] c = new[,] { { 1, 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 1 } };
    int[,] d = new[,] { { 0, 0, 1, 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 1, 0, 0 }, { 1, 1, 1, 1, 1, 1, 1, 1 }, { 0, 0, 1, 0, 0, 1, 0, 0 } };
    int[,] e = new[,] { { 1, 0, 0, 0, 1, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0, 0 } };
    int[,] f = new[,] { { 1, 0, 1, 0 }, { 0, 1, 0, 1 }, { 1, 0, 1, 0 }, { 0, 1, 0, 1 } };
    int[,] g = new[,] { { 1, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };
    int[,] h = new[,] { { 0, 0, 1, 0, 0, 1, 1 }, { 0, 0, 0, 1, 0, 1, 1 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 } };
    int[,] i = new[,] { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 } };
    int[,] j = new[,] { { 1, 0, 0, 0, 1 }, { 0, 1, 0, 1, 0 }, { 0, 0, 2, 0, 0 }, { 0, 1, 0, 1, 0 }, { 1, 0, 0, 0, 1 } };
    int[,] k = new[,] { { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 }, { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 }, { 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

    Console.WriteLine("Chose pattern (a - k): ");
    char selected = Console.ReadKey().KeyChar;
    Console.WriteLine();

    int[,] map = selected switch
    {
        'a' => a,
        'b' => b,
        'c' => c,
        'd' => d,
        'e' => e,
        'f' => f,
        'g' => g,
        'h' => h,
        'i' => i,
        'j' => j,
        'k' => k,
        _ => a
    };

    for (int x = 0; x < map.GetLength(0); x++)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            Console.Write(possibleChars[map[x, y]]);
        }
        Console.WriteLine();
    }
}

void loop31()
{
    Console.WriteLine($"Enter width of diamond: ");
    int width = int.Parse(Console.ReadLine());

    for (int i = 1; i <= width * 2; i += 2)
    {
        int spaces = Math.Abs((width - i) / 2);
        int stars = width - Math.Abs(width - i);

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < stars; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

void loop33()
{
    Console.WriteLine($"Enter depth of Pascal's triangle: ");
    int depth = int.Parse(Console.ReadLine());

    int[][] pascal = new int[depth][];

    for (int n = 0; n < depth; n++)
    {
        pascal[n] = new int[n + 1];
        for (int k = 0; k < n + 1; k++)
        {
            if (k == 0 || k == n) pascal[n][k] = 1;
            else pascal[n][k] = pascal[n - 1][k - 1] + pascal[n - 1][k];
        }
    }

    Console.Clear();
    Console.WriteLine("Pascal's Triangle");

    int width = string.Join(" ", pascal[pascal.Length - 1]).Length;

    for (int i = 0; i < depth; i++)
    {
        int spaces = (width / 2) - (string.Join(" ", pascal[i]).Length / 2);

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < pascal[i].Length; j++)
        {
            Console.Write($"{pascal[i][j]} ");
        }

        Console.WriteLine();
    }
}

while (true)
{
    loop33();
    Console.ReadKey();
    Console.Clear();
}