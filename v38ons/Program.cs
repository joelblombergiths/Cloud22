
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


/* -- Uppg 103, 104, 105


List<Car> cars = new();

foreach(int i in Enumerable.Range(0, 10)) cars.Add(new Car(i));

double totGreenLength = cars.FindAll(x => x.Color.Equals(ConsoleColor.Green)).Sum(x => x.Length);


int place = 0;
List<Car> finished = new();
do
{
    Console.Clear();
    foreach (Car car in cars)
    {
        if (!car.HasArrived)
        {
            car.DriveForOneHour();
        }
        else
        {
            if(!finished.Contains(car))
            {
                car.Place = ++place;
                finished.Add(car);
            }
        }

        car.PrintGraph();
    }

    Thread.Sleep(1000);
}
while (finished.Count < cars.Count);

Console.WriteLine();
Console.WriteLine("Finish!");

*/

/* -- Uppgg 106 
PrivateConstructor p = PrivateConstructor.Create();
Console.WriteLine(p.Id);
PrivateConstructor p2 = PrivateConstructor.Create();
Console.WriteLine(p2.Id);
*/

/* -- Uppg 107 
-> RPSLS
*/
