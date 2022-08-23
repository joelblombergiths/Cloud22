

void ex1()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Joel Blomberg");
}

void ex2()
{
    Console.WriteLine(6 + 2);
}

void ex3()
{
    Console.WriteLine(6 / 2);
}

void ex4()
{
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine((35 + 5) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
}

void ex5()
{
    Console.WriteLine("Input first number: ");
    string n1 = Console.ReadLine();
    Console.WriteLine("Input seccond number: ");
    string n2 = Console.ReadLine();

    string tmp = n1;
    n1 = n2;
    n2 = tmp;
    Console.WriteLine($"First number: {n1}");
    Console.WriteLine($"Seccond number: {n2}");
}

void ex6()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} * {n2} * {n3} = {n1 * n2 * n3}");

}

void ex7()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
    Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");
}

void ex8()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 1; i <=10; i++)
    {
        Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

void ex9()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input fourth number: ");
    int n4 = int.Parse(Console.ReadLine());

    int avg = (n1 + n2 + n3 + n4) / 4;

    Console.WriteLine($"Average of {n1},{n2},{n3},{n4} is {avg}");
}

void ex10()
{
    //(x+y).z and x.y + y.z. 
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"({n1}+{n2})*{n3} = {(n1 + n2) * n3} and {n1}*{n2}+{n1}*{n3} = {n1 * n2 + n1 * n3}");
}

void ex11()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"You look older than {n}");
}

void ex12()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();

        for (int y = 0; y < 4; y++)
        {
            Console.Write(n);
        }
        Console.WriteLine();
    }
}

void ex13()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    int numRows = 5;

    for (int row = 0; row < numRows; row++)
    {
        switch (row)
        {
            case 0:
            case int _ when row == numRows -1: Console.WriteLine($"{n}{n}{n}"); break;
            default: Console.WriteLine($"{n} {n}"); break;
        }
    }
}

ex13();