using System.ComponentModel;

namespace v38ons
{
    internal class Car
    {       
        private readonly int maxDistance = 1000;
        private readonly int graphLength = 20;
        private readonly int _id;
        private readonly int _speed;

        public ConsoleColor Color;
        public double Length;

        private int _place = -1;
        public int Place 
        { 
            get { return _place; } 
            set { if (_place == -1) _place = value; }
        }
                
        private int _distance;
        public int Distance => _distance;
        public bool HasArrived => _distance >= maxDistance;        

        public Car(int id)
        {
            _id = id;
            Color = (ConsoleColor)Random.Shared.Next(16);
            Length = Random.Shared.Next(3, 6);

            _speed = Random.Shared.Next(60, 241);
            _distance = 0;
        }

        public void DriveForOneHour()
        {
            _distance = Math.Min(_distance + _speed, maxDistance);
        }

        public void PrintGraph()
        {
            Console.SetCursorPosition(0, _id);
            int pos = Math.Min(_distance / 10 % 1000 / 5, graphLength);
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|".PadRight(pos,'-'));
         
            Console.ForegroundColor = Color;
            Console.Write("x");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|".PadLeft(graphLength - (pos -1), '-'));
            
            Console.Write($"{_distance} km");

            if (Place > 0) Console.Write($" #{Place}");
        }

        public static List<Car> ManufactureCars(Car templateCar)
        {
            List<Car> cars = new();

            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car(i) { Color = templateCar.Color });
            }

            return cars;
        }
    }
}
