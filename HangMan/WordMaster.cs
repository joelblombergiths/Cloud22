#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.Text;

namespace HangMan
{
    internal class WordMaster
    {
        private static readonly List<string> Words = new() { "awkward", "beekeeper", "cycle", "dizzying", "embezzle", "fishhook", "galvanize", "haiku", "icebox", "jukebox", "kilobyte", "lucky", "microwave", "nightclub", "oxygen", "pixel", "quiz", "rhubarb", "stronghold", "transcript", "unknown", "voodoo", "whiskey", "xylophone", "youthful", "zipper" };

        private string theWord;
        private List<int> foundLetters;
        private List<char> guessedLetters;

        public bool IsGameWon => foundLetters.Count == theWord.Length;
        public string RevealWord => theWord;
        public int WordLength => theWord.Length;
        public string PrevGuesses => string.Join(",", guessedLetters);
        
        public void NewGame()
        {
            guessedLetters = new();
            foundLetters = new();

            theWord = Words.ElementAt(Random.Shared.Next(Words.Count));
        }

        public string GetMaskedWord()
	    {
            StringBuilder sb = new();
            char mask;

            for (int i = 0; i < theWord.Length; i++)
            {
                mask = foundLetters.Contains(i) ? theWord[i] : '_';
                sb.Append(mask);
            }
            return sb.ToString();
	    }

        public bool GuessLetter(char letter)
        {
            letter = char.ToLower(letter);
            bool foundLetter = false;

            if (guessedLetters.Contains(letter)) return false;
            else if (foundLetters.Any(x => theWord[x].Equals(letter))) return true;
            else
            {
                for (int i = 0; i < theWord.Length; i++)
                {
                    if (theWord[i].Equals(letter))
                    {
                        foundLetters.Add(i);
                        foundLetter = true;
                    }
                }
            }

            if(!foundLetter) guessedLetters.Add(letter);

            return foundLetter;
        }

        public bool GuessWord(string word)
        {
            return theWord.Equals(word.ToLower());
        }
    }
}
