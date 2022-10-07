
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

/* Upg 119, 120
 */

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
    public static T[] GenericWhere<T>(this T[] array, Predicate<T> compare)
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