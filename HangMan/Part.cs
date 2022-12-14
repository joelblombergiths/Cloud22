namespace HangMan
{
    abstract class Part
    {
        public abstract void DrawPart();
    }

    class Hill : Part
    {
        public override void DrawPart()
        {
            int left = 12;
            int top = 8;
            Console.SetCursorPosition(left--, top++);
            Console.Write(@"/\");
            Console.SetCursorPosition(left--, top++);
            Console.Write(@"/  \");
            Console.SetCursorPosition(left--, top++);
            Console.Write(@"/    \");
            Console.SetCursorPosition(left, top);
            Console.Write(@"/      \");
        }
    }

    class VerticalBeam : Part
    {
        public override void DrawPart()
        {
            int left = 13;
            int top = 1;
            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|");

            }
        }
    }

    class HorizontalBeam : Part
    {
        public override void DrawPart()
        {
            int left = 3;
            int top = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(left + i, top);
                Console.Write("-");
            }
        }
    }

    class Rope : Part
    {
        public override void DrawPart()
        {
            int left = 2;
            int top = 1;
            Console.SetCursorPosition(left, top);
            Console.Write("|");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("|");
        }
    }

    class Head : Part
    {
        public override void DrawPart()
        {
            int left = 2;
            int top = 3;
            Console.SetCursorPosition(left, top);
            Console.Write("0");
        }
    }

    class Body : Part
    {
        public override void DrawPart()
        {
            int left = 2;
            int top = 4;
            Console.SetCursorPosition(left, top);
            Console.Write("I");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("H");
        }
    }

    class LeftArm : Part
    {
        public override void DrawPart()
        {
            int left = 0;
            int top = 4;
            Console.SetCursorPosition(left, top);
            Console.Write(@"\");
        }
    }

    class RightArm : Part
    {
        public override void DrawPart()
        {
            int left = 4;
            int top = 4;
            Console.SetCursorPosition(left, top);
            Console.Write(@"/");
        }
    }

    class LeftLeg : Part
    {
        public override void DrawPart()
        {
            int left = 1;
            int top = 6;
            Console.SetCursorPosition(left--, top++);
            Console.Write(@"/");
            Console.SetCursorPosition(left, top);
            Console.Write(@"/");
        }
    }

    class RightLeg : Part
    {
        public override void DrawPart()
        {
            int left = 2;
            int top = 6;
            Console.SetCursorPosition(left++, top++);
            Console.Write(@"\");
            Console.SetCursorPosition(left, top);
            Console.Write(@"\");
        }
    }
}
