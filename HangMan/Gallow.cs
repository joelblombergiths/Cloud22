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

namespace HangMan
{
    internal class Gallow
    {
        private static readonly List<Part> parts = new() { new Hill(), new VerticalBeam(), new HorizontalBeam(), new Rope(), new Head(), new Body(), new LeftArm(), new RightArm(), new LeftLeg(), new RightLeg() };
        
        private int stage = 0;
        public bool IsGameOver => stage == parts.Count;

        public void DrawNextPart()
        {
            if (stage < parts.Count)
            {
                Part current = parts.ElementAt(stage);
                current.DrawPart();

                stage++;
            }
        }

        public void Reset()
        {
            stage = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
