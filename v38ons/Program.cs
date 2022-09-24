
using System.Collections;
using v38ons;

/* -- Uppg 99, 100, 102 
Person p = new("J", "B", 1.70, 90);

Console.WriteLine(p.FullName);
Console.WriteLine(p.BMI);

p.FullName = "Joel Blomberg";
Console.WriteLine(p.FirstName);
Console.WriteLine(p.LastName);
*/

/* -- Uppg 101

WeightedColor weightedColor = new();

weightedColor.Blue = 101;
Console.WriteLine($"{weightedColor.Blue} {weightedColor.Red}");
*/


/* -- Uppg 103, 104, 105*/


List<Car> cars = Car.ManufactureCars(10);

double totGreenLength = cars.FindAll(x => x.Color.Equals(ConsoleColor.Green)).Sum(x => x.Length);

Console.WriteLine("Press the Any key to start!");
Console.ReadKey(true);

int hoursElapsed = 0;
List<Car> finished = new();
do
{
    foreach (Car car in cars)
    {
        car.DriveForOneHour();
        
        if (car.HasArrived)        
        {
            if(!finished.Contains(car))
            {
                car.TotalTime = hoursElapsed;
                finished.Add(car);
                car.PrintGraph(true);
            }
        }
        else car.PrintGraph();
    }
    hoursElapsed++;
    Thread.Sleep(1000);
}
while (finished.Count < cars.Count);

Console.SetCursorPosition(0, cars.Count + 1);
Console.WriteLine("Finish!");
Console.ReadKey(true);

//*/

/* -- Uppgg 106 
PrivateConstructor p = PrivateConstructor.Create();
Console.WriteLine(p.Id);
PrivateConstructor p2 = PrivateConstructor.Create();
Console.WriteLine(p2.Id);
*/

/* -- Uppg 107 
-> RPSLS
*/
