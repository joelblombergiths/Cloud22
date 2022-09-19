namespace v38mon
{
    internal abstract class Animal
    {
        public string Name;
                
        private bool isHungry = true;

        internal Animal() : this("Unkown") { }
        
        internal Animal(string name)
        {
            Name = name;
        }

        public abstract void Speak();

       
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            else Console.WriteLine($"{Name} is not hungry");
        }
    }
}
