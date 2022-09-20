#pragma warning disable CS8603 // Possible null reference return.
using HangMan;

const int WORD_ROW = 13;
const int PREV_ROW = 14;
const int GUESS_ROW = 15;
const int NEWGAME_ROW = 17;

Gallow gallow = new();
WordMaster wordMaster = new();

do
{
    gallow.Reset();
    wordMaster.NewGame();

    bool isGameOver = false;
    do
    {
        PrintMaskedWord();
        PrintPrevGuesses();

        string currGuess = RequestUserInput();

        if (currGuess.Length == 1)
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
            if (wordMaster.GuessWord(currGuess))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail");
            }

            isGameOver = true;
        }
    }
    while (!isGameOver);

    PrintMaskedWord(true);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(0, NEWGAME_ROW);
    Console.WriteLine("Press the Any key to guess a new word.");
    Console.ReadKey(true);    
}
while (true);

void PrintMaskedWord(bool revealWord = false)
{
    Console.SetCursorPosition(0, WORD_ROW);
    string word = revealWord ? wordMaster.RevealWord : wordMaster.GetMaskedWord();
    Console.Write($"Word({wordMaster.WordLength}): {word}");
}

void PrintPrevGuesses()
{
    Console.SetCursorPosition(0, PREV_ROW);
    Console.Write($"Previous Guesses: {wordMaster.PrevGuesses}");
}

string RequestUserInput()
{
    string? input;
    bool isValidInput;
    do
    {
        Console.SetCursorPosition(33, GUESS_ROW);
        Console.Write("".PadRight(4, ' '));

        Console.SetCursorPosition(0, GUESS_ROW);
        Console.Write("Guess a Letter or the whole Word: ");
        input = Console.ReadLine();

        if (input?.Length == 1) isValidInput = char.IsLetter(input[0]);
        else isValidInput = !string.IsNullOrWhiteSpace(input);
    }
    while (!isValidInput);

    return input;
}
