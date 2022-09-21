using static v38ons.GameMaster;

namespace v38ons
{
    internal class Player
    {        
        private readonly int[] _scorePos;
        private readonly string _name;

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

        public Player(string playerName, int[] scorePos)
        {
            _name = playerName;
            _scorePos = scorePos;
        }

        public Choice GetChoice()
        {
            return (Choice)Random.Shared.Next(5);
        }

        private void PrintScore()
        {
            Console.SetCursorPosition(_scorePos[0], _scorePos[1]);
            Console.Write($"{_name}: {_score}");
        }

        public override string ToString() => _name;
    }
}
