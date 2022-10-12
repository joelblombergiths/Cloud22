using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    internal class GameButton : Button
    {
        public int Value { get; set; }
        public GameButton(int value) : base()
        {
            Value = value;
        }
    }
}
