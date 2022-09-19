
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


for (int i = 0; i < 10; i++)
{
    gallow.DrawNextPart();
    Thread.Sleep(500);
}

Console.ReadKey(true);
