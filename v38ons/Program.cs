
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

/* -- Uppg 107 */

Player p1 = new("P1", new int[] { 0, 0 }) { Score = 0 };
Player p2 = new("P2", new int[] { 15, 0 }) { Score = 0 };

do
{
    GameMaster.Choice p1Choice = p1.GetChoice();
    GameMaster.Choice p2Choice = p2.GetChoice();

    Console.SetCursorPosition(0, 2);
    Console.WriteLine($"{p1} chose {p1Choice}".PadRight(50, ' '));
    Console.WriteLine($"{p2} chose {p2Choice}".PadRight(50, ' '));

    GameMaster.Result result = GameMaster.CheckResult(p1Choice, p2Choice, out string reason);

    if (result.Equals(GameMaster.Result.Win))
    {
        Console.WriteLine($"{reason}. {p1} wins.".PadRight(50, ' '));
        p1.Score++;
    }
    else if (result.Equals(GameMaster.Result.Lose))
    {
        Console.WriteLine($"{reason}. {p2} wins.".PadRight(50, ' '));
        p2.Score++;
    }
    else
    {
        Console.WriteLine(reason.PadRight(50, ' '));
    }

    Thread.Sleep(3000);
}
while (true);