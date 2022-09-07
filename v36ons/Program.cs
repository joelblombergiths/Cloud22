#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8321 // Local function is declared but never used


void uppg56()
{
    Console.WriteLine("Enter first name:");
    string firstName = Console.ReadLine();

    Console.WriteLine("Enter last name:");
    string lastName = Console.ReadLine();

    PrintFullName(firstName, lastName);

    void PrintFullName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}

void uppg57()
{
    Console.WriteLine("Enter first name:");
    string firstName = Console.ReadLine();

    Console.WriteLine("Enter last name:");
    string lastName = Console.ReadLine();

    string fullName = GetFullName(firstName, lastName);
    Console.WriteLine(fullName);

    string GetFullName(string firstName, string lastName)
    {
        return ($"{firstName} {lastName}");
    }
}

void uppg58()
{
    Console.WriteLine("Enter number to show multiplication table:");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(GetMultiplicationEquation(number, i));
    }

    string GetMultiplicationEquation(int number, int level)
    {
        return $"{number} * {level} = {number * level}";
    }
}

void uppg59()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();


    Console.WriteLine(CapitilizeWords(text, false));

    string CapitilizeWords(string text, bool everyWord)
    {
        string result = string.Empty;

        string[] words = text.Split();

        if (everyWord)
        {
            string eachWordCapitalized;
            for (int i = 0; i < words.Length; i++)
            {
                eachWordCapitalized = CapitilizeWord(words[i]);
                words[i] = eachWordCapitalized;
            }
        }
        else
        {
            string firstWordCapitalized = CapitilizeWord(words[0]);
            words[0] = firstWordCapitalized;
        }

        result = string.Join(" ", words);

        return result;
    }

    string CapitilizeWord(string word)
    {
        char firstLetter = char.ToUpper(word[0]);
        string restOfWord = word[1..].ToLower();

        return firstLetter + restOfWord;
    }
}

void uppg60()
{
    int maxScreenWidth = 100;
    int maxScreenHeight = 30;

    char characterToPrint = 'X';

    do
    {
        do
        {
            int randomLeft = Random.Shared.Next(0, maxScreenWidth);
            int randomTop = Random.Shared.Next(0, maxScreenHeight);

            WriteCharacterAtPosition(randomLeft, randomTop, characterToPrint);

            Thread.Sleep(500);
        }
        while (!Console.KeyAvailable);

        characterToPrint = Console.ReadKey(true).KeyChar;
    }
    while (true);

    void WriteCharacterAtPosition(int left, int top, char character = 'X')
    {
        Console.SetCursorPosition(left, top);

        Console.Write(character);
    }
}

void uppg61()
{
    int maxScreenWidth = 100;
    int maxScreenHeight = 30;

    int boxWidth;
    int boxHeight;

    do
    {
        boxWidth = Random.Shared.Next(5, 10);
        boxHeight = Random.Shared.Next(3, 7);

        int randomLeft = Random.Shared.Next(0, maxScreenWidth - boxWidth);
        int randomTop = Random.Shared.Next(0, maxScreenHeight - boxHeight);

        DrawBox(boxWidth, boxHeight, randomLeft, randomTop);

        Thread.Sleep(500);
    } while (true);

    void DrawBox(int width, int height, int left = 0, int top = 0)
    {

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.SetCursorPosition(left + j, top + i);
                if ((i == 0 || i == height - 1) || (j == 0 || j == width - 1))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("-");
                }
            }
        }
    }
}

void uppg62()
{
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();

    Console.WriteLine("Enter number:");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine(CheckStringLength(text, number));

    bool CheckStringLength(string text, int length)
    {
        if (text.Length > length) return true;

        return false;
    }
}

void uppg63()
{
    Console.WriteLine(MyJoin("-", "test", "av", "funktion"));

    string MyJoin(string separator, params string[] parts)
    {
        if (parts.Length < 1) return string.Empty;
        else if (parts.Length == 1) return parts[0];
        else
        {
            string newString = parts[0] + separator;
            for (int i = 1; i < parts.Length - 1; i++)
            {
                newString += parts[i] + separator;
            }
            newString += parts[^1];

            return newString;
        }
    }
}

void uppg64()
{
    Console.WriteLine(Average(new int[] { 1,2,3,4,5,6}));

    double Average(int[] numbers)
    {
        double sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

}

void uppg65()
{
    Console.WriteLine(string.Join(" ",GetNameOfDigitsInNumber(1234)));

    string[] GetNameOfDigitsInNumber(int number)
    {
        string[] digitNames = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        int[] digits = number.ToString().Select(x => int.Parse(x.ToString())).ToArray();

        string[] nameOfDigits = new string[digits.Length];

        for (int i = 0; i < digits.Length; i++)
        {
            nameOfDigits[i] = digitNames[digits[i]];
        }

        return nameOfDigits;
    }
}

void uppg66()
{
    Console.WriteLine("Enter number:");
    int number = int.Parse(Console.ReadLine());

    WriteNumberWithWords(number);
    Console.WriteLine();

    void WriteNumberWithWords(int number)
    {
        if (number / 1000000 > 0)
        {
            WriteNumberWithWords(number / 1000000);
            Console.Write(" Milion ");
            WriteNumberWithWords(number % 1000000);
        }
        else if (number / 1000 > 0)
        {
            WriteNumberWithWords(number / 1000);
            Console.Write(" Thousand ");
            WriteNumberWithWords(number % 1000);
        }
        else if (number / 100 > 0)
        {
            WriteNumberWithWords(number / 100);
            Console.Write(" Hundred ");
            WriteNumberWithWords(number % 100);
        }
        else if (number > 10 && number < 20)
        {
            Console.Write(GetSpecialNumberAsText(number % 10));
        }
        else if (number / 10 > 0)
        {
            Console.Write(GetTenthNumberAsText(number / 10) + " ");
            WriteNumberWithWords(number % 10);
        }
        else if (number > 0) Console.Write(GetDigitAsText(number));
    }

    string GetTenthNumberAsText(int number)
    {
        string[] tenthNames = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        return tenthNames[number - 1];
    }

    string GetSpecialNumberAsText(int number)
    {
        string[] specialNames = { "Eleven", "Twelve","Thirteen", "Forteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        return specialNames[number - 1];
    }

    string GetDigitAsText(int number)
    {
        string[] digitNames = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        return digitNames[number - 1];        
    }
}

while (true)
{
    uppg66();
    Console.ReadKey(true);
}