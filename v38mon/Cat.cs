using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v38mon
{
    internal class Cat : Animal
    {
        public enum Breeds
        {
            Unknown,
            Siamese,
            Bond,
            fluff
        }

        public Breeds Breed;

        public Cat() : base() { }
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine("Mijau");
        }

        public override string ToString()
        {
            return $"{Name} is a {Breed} ";
        }
    }
}
