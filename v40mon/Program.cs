
/* uppg 112, 113 
PrintName(FullName);
PrintName(FullNameExtended);


void PrintName(Func<string, string, string> print)
{
    Console.WriteLine(print("Knatte", "Anka"));
    Console.WriteLine(print("Fnatte", "Anka"));
    Console.WriteLine(print("Tjatte", "Anka"));
}

string FullNameExtended(string firstName, string lastName)
{
    return $"{nameof(firstName)}: {firstName}\n{nameof(lastName)}: {lastName}";
}

string FullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}

delegate string CombineName(string firstName, string lastName);
*/

/* uppg 115
Action<int, int> printSum = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");
printSum(1, 2);
*/

/* uppg 116
Func<int, int, int> getSum = (a, b) => a + b;
Console.WriteLine(getSum(1,2));
*/

/*Uppg 117
PrintName((f, l) => $"{f} has {f.Length} letters, {l} has {l.Length} letters");

void PrintName(Func<string, string, string> print)
{
    Console.WriteLine(print("Knatte", "Anka"));
    Console.WriteLine(print("Fnatte", "Anka"));
    Console.WriteLine(print("Tjatte", "Anka"));
}

*/

/*Uppg 118

string[] cities = new string[] { "Gothenburg", "Los Angeles", "Tokyo", "London", "Seoul" };

PrintArray(cities, x => x);
Console.WriteLine();

PrintArray(cities, x => x.ToUpper());
Console.WriteLine();

PrintArray(cities, x => x[..3]);
Console.WriteLine();

PrintArray(cities, x => x.Length.ToString());
Console.WriteLine();


void PrintArray(string[] cities, Func<string,string> modifier)
{
    foreach (string city in cities)
    {
        Console.WriteLine(modifier(city));
    }
}
*/

/* Upg 119, 120*/


int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    numbers[i] = Random.Shared.Next(-50, 51);
}

numbers.PrintWhere(x => x < 0);
Console.WriteLine();

numbers.PrintWhere(x => x >= 10 && x <= 20);
Console.WriteLine();

numbers.PrintWhere(x => x % 2 == 0);
Console.WriteLine();

foreach (int n in numbers.Where(x => x % 2 == 0))
{
    Console.WriteLine(n);
}


static class Extension
{
    public static T[] GenericWhere<T>(this T[] array, Func<T,bool> compare)
    {
        List<T> list = new();
        foreach (T n in array)
        {
            if (compare(n)) list.Add(n);
        }

        return list.ToArray();
    }

    public static int[] Where(this int[] numbers, Predicate<int> compare)
    {
        List<int> list = new();
        foreach (int n in numbers)
        {
            if (compare(n)) list.Add(n);
        }

        return list.ToArray();
    }

    public static void PrintWhere(this int[] numbers, Predicate<int> compare)
    {
        foreach (int n in numbers)
        {
            if (compare(n)) Console.WriteLine(n);
        }
    }
}


/*Uppg 121

var persons = new[]
{
     new { FirstName = "Alfa", LastName = "Beck", Age = 7, Height = 1.27f, Weight = 30.5f },
     new { FirstName = "Bravo", LastName = "Rosenberg", Age = 12, Height = 1.4f, Weight = 44.5f },
     new { FirstName = "Charlie", LastName = "Apperlo", Age = 17, Height = 170f, Weight = 80.9f },
     new { FirstName = "Delta", LastName = "Ruzsa", Age = 17, Height = 1.52f, Weight = 40.5f },
     new { FirstName = "Echo", LastName = "Moss", Age = 21, Height = 1.53f, Weight = 60.5f },
     new { FirstName = "Foxtrot", LastName = "Spears", Age = 22, Height = 1.6f, Weight = 60.5f },
     new { FirstName = "Golf", LastName = "Leslie", Age = 47, Height = 1.7f, Weight = 99.5f },
     new { FirstName = "Hotel", LastName = "Hiedler", Age = 51, Height = 1.78f, Weight = 90.5f },
     new { FirstName = "India", LastName = "Schmitz", Age = 78, Height = 1.78f, Weight = 104.5f },
     new { FirstName = "Juliett", LastName = "Pasternack", Age = 101, Height = 1.47f, Weight = 180.5f }
};

persons.Where(x => x.Age >= 20 && x.Age <= 40);

persons.Where(x => x.FirstName.Length > x.LastName.Length).Select(x => new { x.FirstName, x.LastName });

persons.Select(x => new { Name = $"{x.FirstName} {x.LastName}", BMI = x.Weight / MathF.Pow(x.Height, 2) }).Where(x => x.BMI < 20 || x.BMI > 25);

persons.Select(x => new { Username = $"{x.FirstName[..3]}{x.Age}", Category = x.Age < 18 ? "Child" : "Adult" });



*/