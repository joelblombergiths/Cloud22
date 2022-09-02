#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8321 // Local function is declared but never used


void uppg1()
{
    int[] array = Enumerable.Range(1, 10).ToArray();

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }    
}
void uppg2()
{
    int[] array = Enumerable.Range(1, 10).ToArray();

    foreach (int n in array)
    {
        Console.WriteLine(n * 2);
    }
}

void uppg24()
{
    string text = "Hello World!";
    for (int i = 0; i < text.Length; i++)
    {
        Console.Write(text[^(i + 1)]);
    }
}

void uppg25()
{
    string text = "Hello World!";

    for (int i = 0; i < text.Length; i++)
    {
        Console.Write(text[i] == 'o' ? 'X' : text[i]);
    }
}

void uppg26()
{
    string text = "Hello World!";

    for (int i = 0; i < text.Length; i++)
    {
        Console.Write(i % 2 == 0 ? text[i] : 'X');
    }
}

void uppg27()
{
    string text = "Hello World!";

    for (int i = 0; i < text.Length; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(text[j]);
        }

        Console.WriteLine();
    }
}

void uppg28()
{
    Console.WriteLine("Enter text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Enter length to display: ");
    int length = int.Parse(Console.ReadLine());

    for (int i = 0; i < length; i++)
    {
        Console.Write(text[i]);
    }
}
void uppg29()
{
    Console.WriteLine("Enter text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Enter character to color: ");
    char specialChar = Console.ReadKey().KeyChar;
    Console.WriteLine();

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == specialChar) Console.ForegroundColor = ConsoleColor.Red;            
        else Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(text[i]);
    }    
}

void uppg30()
{
    Console.WriteLine("Enter text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Enter start index: ");
    int start = RequestNumber();

    Console.WriteLine("Enter stop index: ");
    int stop = RequestNumber();

    for (int i = 0; i < text.Length; i++)
    {
        if(i >= start && i <= stop) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.White;
        Console.Write(text[i]);
    }

    int RequestNumber()
    {
        int inputNumber;
        bool isValidInput;
        do
        {
            isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
            if (!isValidInput) Console.WriteLine("Invalid Input");
        } while (!isValidInput);

        return inputNumber;
    }
}

void uppg31()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    Console.WriteLine("Enter letter:");
    char letter = Console.ReadKey().KeyChar;
    Console.WriteLine();

    bool doColor = false;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == letter)
        {
            if (doColor)
            {
                Console.Write(text[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text[i]);                    
            }
            doColor = !doColor;
        }
        else Console.Write(text[i]);        
    }

    Console.ForegroundColor = ConsoleColor.Gray;
}

void uppg32()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    char[] vowels = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
    int numVowels = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (vowels.Contains(text[i])) numVowels++;
    }

    Console.WriteLine($"Text contains {numVowels} vowels");
}

void uppg33()
{
    Console.WriteLine("Enter number:");
    string input = Console.ReadLine();

    string[] numberText = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    
    for (int i = 0; i < input.Length; i++)
    {
        int numIndex = int.Parse(input[i].ToString());
        Console.Write(numberText[numIndex]);
        if (i < input.Length - 1) Console.Write("-");
    }
}

void uppg34()
{
    const int NUMWORDS = 7;

    string[] words = new string[NUMWORDS];
    for (int i = 0; i < NUMWORDS; i++)
    {
        Console.Write($"Enter word #{i + 1}: ");
        words[i] = Console.ReadLine();
    }

    for (int i = NUMWORDS - 1; i >= 0; i--)
    {
        Console.WriteLine(words[i]);
    }
}



while (true)
{
    uppg34();
    Console.ReadKey();
    Console.Clear();
}