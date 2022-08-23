// See https://aka.ms/new-console-template for more information

using System.Linq;

Console.WriteLine("Mini Upg 1");
for(int i = 9; i > 0; i--)
{
    Console.Write(i);
}

Console.WriteLine();

Console.WriteLine(string.Concat(Enumerable.Range(1,9).Reverse()));


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Mini Upg 2");
Console.Write("Name, please: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(name);
}
