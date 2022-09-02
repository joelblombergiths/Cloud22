﻿#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8321 // Local function is declared but never used
#pragma warning disable CS8601 // Possible null reference assignment.

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
        if (i >= start && i <= stop) Console.ForegroundColor = ConsoleColor.Red;
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

void uppg35()
{
    List<string> prevWords = new();
    do
    {
        Console.WriteLine("Write word: ");
        prevWords.Add(Console.ReadLine());

        if (prevWords.Count < 10)
        {
            Console.WriteLine("I don't have 10 words yet");
        }
        else
        {
            Console.WriteLine($"10 words ago you said {prevWords[^10]}");
        }
    } while (true);
}


/*
 Console.SetCursorPosition() kan man använda för att flytta textmarkören i konsolen.
(ex: SetCursorPosition(5, 3) sätter markören 6 tecken in från vänster, och 4 steg från toppen av skärmen). 
Skriv ett program som skriver siffran 0 i början på de 10 första raderna. 
Varje sekund som går ska sedan en (Random) av de 10 räknarna öka med 1.
Den rad/räknare som senast uppdaterades ska skrivas med röd text.
 */


void uppg36()
{
    const int TOP = 4;
    const int LEFT = 6;

    int[] counters = new int[10];
    int lastUpdated = -1;
    do
    {
        Console.Clear();
        for (int i = 0; i < counters.Length; i++)
        {
            if (i == lastUpdated) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(LEFT, TOP + i);
            Console.Write(counters[i]);
        }

        Thread.Sleep(1000);

        lastUpdated = Random.Shared.Next(0, counters.Length);
        counters[lastUpdated] += 1;

    } while (true);
}

void uppg37()
{
    const int HEIGHT = 10;
    const int WIDTH = 15;
    int[] playerPos = new int[2] { (int)Math.Ceiling(WIDTH / 2M), (int)Math.Ceiling(HEIGHT / 2M), };
    Console.CursorVisible = false;

    do
    {
        Console.Clear();
        for (int i = 0; i < HEIGHT; i++)
        {
            for (int j = 0; j < WIDTH; j++)
            {
                Console.Write((i == 0 || i == HEIGHT - 1) || (j == 0 || j == WIDTH - 1) ? "X" : " ");
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(playerPos[0], playerPos[1]);
        Console.Write("O");

        (int x, int y) = Console.ReadKey().Key switch
        {
            ConsoleKey.LeftArrow => (-1, 0),
            ConsoleKey.RightArrow => (1, 0),
            ConsoleKey.UpArrow => (0, -1),
            ConsoleKey.DownArrow => (0, 1),
            _ => (0, 0)
        };

        int newX = playerPos[0] + x;
        int newY = playerPos[1] + y;
        if (newX < WIDTH - 1 && newX > 0 && newY < HEIGHT - 1 && newY > 0)
        {
            playerPos[0] = newX;
            playerPos[1] = newY;
        }
    } while (true);
}


while (true)
{
    uppg37();
    Console.ReadKey();
    Console.Clear();
}
