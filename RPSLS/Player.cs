#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
using static RPSLS.GameMaster;

namespace RPSLS
{
    internal class Player
    {
        private static readonly CursorLocation[] possibleScorePos = { new() { Left = 0, Top = 0 }, new() { Left = 15, Top = 0 } };
        
        private readonly CursorLocation _scorePos;
        private readonly string _name;
        private readonly bool _isComputerPlayer;

        private int _score = 0;
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                PrintScore();
            }
        }
        public override string ToString() => _name;

        private Player(string playerName, bool isComputerPlayer, CursorLocation scorePos)
        {
            _name = playerName;
            _scorePos = scorePos;
            _isComputerPlayer = isComputerPlayer;
        }

        public static Player CreatePlayer(int number)
        {
            Console.Clear();

            Console.WriteLine($"Enter name for Player {number}");
            string name = Console.ReadLine();

            bool isValidInput = false;
            bool isComputer = false;
            do
            {
                Console.WriteLine("Is Computer Player? (Y/N)");
                string input = Console.ReadLine();

                if (input.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                {
                    isComputer = true;
                    isValidInput = true;
                }
                else if (input.StartsWith("N", StringComparison.OrdinalIgnoreCase))
                {
                    isComputer = false;
                    isValidInput = true;
                }
            } 
            while (!isValidInput);

            return new Player(name, isComputer, possibleScorePos[number]);
        }

        public Choice GetChoice()
        {
            if (_isComputerPlayer) return (Choice)Random.Shared.Next(5);
            else return RequestUserInput();
        }
        private void PrintScore()
        {
            Console.SetCursorPosition(_scorePos.Left, _scorePos.Top);
            Console.Write($"{_name}: {_score}");
        }

        private static Choice RequestUserInput()
        {
            bool isValidInput;
            Choice choice;
            do
            {                
                Console.SetCursorPosition(0, 6);

                Console.Write($"Enter {string.Join(" or ", Enum.GetNames(typeof(Choice)))}: ");
                string input = Console.ReadLine();

                isValidInput = Enum.TryParse(input, true, out choice);

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("".PadRight(100, ' '));
            } while (!isValidInput);

            return choice;
        }

    }
}