
/*
Console.WriteLine(@"   ----------");
Console.WriteLine(@"  |          |");
Console.WriteLine(@"  |          |");
Console.WriteLine(@"  0          |");
Console.WriteLine(@"\ H /        |");
Console.WriteLine(@"  H          |");
Console.WriteLine(@" / \         |");
Console.WriteLine(@"/   \        |");
Console.WriteLine(@"            /\");
Console.WriteLine(@"           /  \");
Console.WriteLine(@"          /    \");
Console.WriteLine(@"         /      \");
*/


using HangMan;

Gallow gallow = new();
WordMaster wordMaster = new();

string currGuess;
bool isGameOver = false;
do
{
    PrintMaskedWord();
    PrintPrevGuesses();

    currGuess = RequestUserInput();

    if(currGuess.Length == 1)
    {
        if (wordMaster.GuessLetter(currGuess[0]))
        {
            if (wordMaster.IsGameWon)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                isGameOver = true;
            }
        }
        else
        {
            gallow.DrawNextPart();

            if (gallow.IsGameOver)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Died!");
                isGameOver = true;
            }
        }
    }
    else
    {
        if(wordMaster.GuessWord(currGuess))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            isGameOver = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fail");
            isGameOver = true;
        }
    }
}
while (!isGameOver);

PrintMaskedWord(true);

void PrintMaskedWord(bool revealWord = false)
{
    Console.SetCursorPosition(0, 13);
    string w = revealWord ? wordMaster.RevealWord : wordMaster.GetMaskedWord();
    Console.Write($"Word: {w}");
}

void PrintPrevGuesses()
{
    Console.SetCursorPosition(0, 14);
    Console.Write($"Previous Guesses: {wordMaster.GetPrevGuesses()}");
}

string RequestUserInput()
{
    string input;
    do
    {
        Console.SetCursorPosition(33, 15);
        Console.Write("".PadRight(50,' '));

        Console.SetCursorPosition(0, 15);
        Console.Write("Guess a Letter or the whole Word: ");
        input = Console.ReadLine();
    }
    while (string.IsNullOrEmpty(input));

    return input;
}

Console.ReadKey(true);
