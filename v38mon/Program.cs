#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
using System.Runtime.InteropServices;
using v38mon;

/* -- Uppg 90, 91
Dog rottweiler = new() { Name = "Fido", Breed = Dog.Breeds.Rottweiler, Weight = 21.3 };
Dog pudel = new() { Name = "Leonard", Breed = Dog.Breeds.Pudel, Weight = 13.2 };
Dog stray = new();

Cat siamese = new() { Name = "Sigge", Breed = Cat.Breeds.Siamese };

Console.WriteLine(pudel);
Console.WriteLine("Speak!");
pudel.Speak();
pudel.Eat();
pudel.Eat();

Console.WriteLine();

Console.WriteLine(siamese);
Console.WriteLine("Speak!");
siamese.Speak();

Console.WriteLine();

Console.WriteLine(rottweiler);
Console.WriteLine(stray);
*/

/* -- Uppg 92, 93
 

Box box = new(5, 5);
Console.WriteLine($"Area:{box.Area}, Circ.: {box.Circumference}");

box.PrintArea();
box.PrintCircumference();

box.PrintArea();
box.PrintCircumference();

Console.WriteLine();
box.ChangeSize(width: 10);

box.PrintArea();
box.PrintCircumference();

*/

/* -- Uppg 94*/
User u = new();

u.SetPassword("123abc", "kalle");
u.SetPassword("123abc", "abc123");
u.SetPassword("12345678", "123abc");
//*/

/* -- uppg 96, 97
List<StepCounter> counters = new();

for (int i = 0; i < 10; i++)
{
    counters.Add(new StepCounter());
}

for (int i = 0; i < 1000; i++)
{
    int r = Random.Shared.Next(0, counters.Count);
    counters[r].Step();
}

foreach(StepCounter counter in counters)
{
    counter.PrintCounter();
}
*/

/* -- Extrauppg 97
Console.CursorVisible = false;

const int TOP = 4;
const int LEFT = 6;

int numCounters = 15;

List<StepCounter> counters = StepCounter.GetStepCounters(numCounters);

int lastUpdated = -1;
do
{
    Console.Clear();

    foreach(StepCounter counter in counters)
    {
        if(counter.Id == lastUpdated) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.Gray;

        Console.SetCursorPosition(LEFT, TOP + counter.Id);
        Console.Write(counter.Current);
    }       

    lastUpdated = Random.Shared.Next(counters.Count);
    StepCounter update = counters.Find(x => x.Id.Equals(lastUpdated));

    if (update.Current >= 9) update.Reset();
    else update.Step();    

    Thread.Sleep(1000);
}
while (true);
*/

/* Uppg 98

Person me = new()
{
    Name = "Joel",
    Age = 38,
    Mother = new() 
    {
        Name = "Susanne",
        Age = 65,
        Mother = new()
        {
            Name = "Gull-May",
            Age = 85
        },
        Father = new()
        {
            Name = "Morfar",
            Age = -1
        }
    },
    Father = new()
    {
        Name = "Anders",
        Age = 64,
        Mother = new()
        {
            Name = "Britta",
            Age = -1
        },
        Father = new()
        {
            Name = "Farfar",
            Age = -1
        }
    }
};

*/