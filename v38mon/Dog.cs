using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v38mon
{
    internal class Dog : Animal
    {
        public enum Breeds
        {
            Unkown,
            Rottweiler,
            Pudel,
            Labrador
        }

        public Breeds Breed;
        public double Weight;

        public Dog() : base() { }
        public Dog(string name) : base(name) { }
        public override string ToString()
        {
            return $"{Name} is a {Breed} and weight {Weight} Kg";
        }

        public override void Speak()
        {
            Console.WriteLine("Woff");
        }
    }
}
