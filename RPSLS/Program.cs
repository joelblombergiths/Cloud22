using RPSLS;
using static RPSLS.GameMaster;

Player p1 = Player.CreatePlayer(1);
Player p2 = Player.CreatePlayer(2);

Console.Clear();

p1.Score = 0;
p2.Score = 0;

do
{
    Choice p1Choice = p1.GetChoice();
    Choice p2Choice = p2.GetChoice();

    Console.SetCursorPosition(0, 2);
    Console.WriteLine($"{p1} chose {p1Choice}".PadRight(50, ' '));
    Console.WriteLine($"{p2} chose {p2Choice}".PadRight(50, ' '));

    Result result = CheckResult(p1Choice, p2Choice, out string reason);

    if (result.Equals(Result.Win))
    {
        Console.WriteLine($"{reason}. {p1} wins.".PadRight(50, ' '));
        p1.Score++;
    }
    else if (result.Equals(Result.Lose))
    {
        Console.WriteLine($"{reason}. {p2} wins.".PadRight(50, ' '));
        p2.Score++;
    }
    else
    {
        Console.WriteLine(reason.PadRight(50, ' '));
    }

    Thread.Sleep(1000);
}
while (true);