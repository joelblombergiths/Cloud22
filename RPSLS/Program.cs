using RPSLS;
using static RPSLS.GameMaster;

Player p0 = Player.CreatePlayer(0);
Player p1 = Player.CreatePlayer(1);

Console.Clear();

p0.Score = 0;
p1.Score = 0;

do
{
    Choice p0Choice = p0.GetChoice();
    Choice p1Choice = p1.GetChoice();

    Console.SetCursorPosition(0, 2);
    Console.WriteLine($"{p0} chose {p0Choice}".PadRight(50, ' '));
    Console.WriteLine($"{p1} chose {p1Choice}".PadRight(50, ' '));

    Result result = CheckResult(p0Choice, p1Choice, out string reason);

    if (result.Equals(Result.Win))
    {
        Console.WriteLine($"{reason}. {p0} wins.".PadRight(50, ' '));
        p0.Score++;
    }
    else if (result.Equals(Result.Lose))
    {
        Console.WriteLine($"{reason}. {p1} wins.".PadRight(50, ' '));
        p1.Score++;
    }
    else
    {
        Console.WriteLine(reason.PadRight(50, ' '));
    }

    Thread.Sleep(1000);
}
while (true);