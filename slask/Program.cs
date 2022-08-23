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
string name = Console.ReadLine();

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(name);
}
