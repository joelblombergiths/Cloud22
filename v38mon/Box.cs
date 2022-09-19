using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v38mon
{
    internal class Box
    {
        private int _length;
        private int _width;
               
        public int Area { get { return _length * _width; } }
        public int Circumference { get { return _length * 2 + _width * 2; } }

        public Box (int length, int width)
        {
            _length = length;
            _width = width;
        }

        public void ChangeSize(int length = -1, int width = -1)
        {
            _length = length >= 0 ? length : _length;
            _width = width >= 0 ? width : _width;
        }
        public void PrintArea() => Console.WriteLine($"Area is {Area}");
        public void PrintCircumference() => Console.WriteLine($"Circumference is {Circumference}");
    }
}
