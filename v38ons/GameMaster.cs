namespace v38ons
{
    internal static class GameMaster
    {
        public enum Choice
        {
            Rock,
            Paper,
            Scissors,
            Lizard,
            Spock
        }

        public enum Result
        {
            Win,
            Lose,
            Tie
        }

        private static readonly List<(Choice winningChoice, Choice losingChoice, string reason)> combinations = new()
        {
            (Choice.Scissors, Choice.Paper, "Scissors cuts Paper"),
            (Choice.Paper, Choice.Rock, "Paper covers Rock"),
            (Choice.Rock, Choice.Lizard, "Rock crushes Lizard"),
            (Choice.Lizard, Choice.Spock, "Lizard poisons Spock"),
            (Choice.Spock, Choice.Scissors, "Spock smashes Scissors"),
            (Choice.Scissors, Choice.Lizard, "Scissors decapitates Lizard"),
            (Choice.Lizard, Choice.Paper, "Lizard eats Paper"),
            (Choice.Paper, Choice.Spock, "Paper disproves Spock"),
            (Choice.Spock, Choice.Rock, "Spock vaporizes Rock"),
            (Choice.Rock, Choice.Scissors, "Rock crushes Scissors")
        };

        public static Result CheckResult(Choice defender, Choice chalenger, out string reason)
        {
            if (defender == chalenger)
            {
                reason = "It's a Tie!";
                return Result.Tie;
            }
            else
            {
                List<Choice> selectedChoices = new() { defender, chalenger };

                (Choice winningChoice, Choice loosingChoice, reason) = combinations.Find(x => selectedChoices.Contains(x.winningChoice) && selectedChoices.Contains(x.losingChoice));

                return defender == winningChoice ? Result.Win : Result.Lose;
            }
        }
    }
}
