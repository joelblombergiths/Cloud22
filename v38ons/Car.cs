using System.ComponentModel;

namespace v38ons
{
    internal class Car
    {       
        private static int graphLength = 20;
        private readonly int maxDistance = 10000;
        private readonly int _id;
        private readonly int _speed;

        public ConsoleColor Color;
        public double Length;

        private int _totalTime = -1;
        public int TotalTime
        { 
            get { return _totalTime; } 
            set { if (_totalTime == -1) _totalTime = value; }
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

        public void PrintGraph(bool printFinish = false)
        {
            Console.SetCursorPosition(0, _id);
            
            int pos = printFinish ? graphLength : Math.Min(_distance % maxDistance / (maxDistance / graphLength), graphLength);

            Console.Write($"{_speed} km/h".PadRight(9, ' '));

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"|{new string('-', pos)}");
         
            Console.ForegroundColor = Color;
            Console.Write("x");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{new string('-', graphLength - pos)}|");

            Console.Write($"{_distance} km");

            if (printFinish) Console.Write($" Finished in {TotalTime} hours");
        }

        public static List<Car> ManufactureCars(int count, Car? templateCar = null, bool useColor = false, bool useLength = false)
        {
            List<Car> cars = new();

            for (int i = 0; i < count; i++)
            {
                Car newCar = new(i);
                if (templateCar != null)
                {
                    if (useColor) newCar.Color = templateCar.Color;
                    if (useLength) newCar.Length = templateCar.Length;
                }
                cars.Add(newCar);
            }

            return cars;
        }
    }
}
