do
{
    int number;
    do
    {
        Console.Write("enter a 4 digit number where all digits are not the same: ");
        string? input = Console.ReadLine();

        if (input?.Length == 4)
        {
            if (int.TryParse(input, out number))
            {
                var check = Digits(number);
                if (!check.All(x => x == check.First())) break;
                else Console.Clear();
            }
            else Console.Clear();
        }
        else Console.Clear();
    }
    while (true);

    int counter = 0;
    do
    {
        var digits = Digits(number);
        int desc = Desc(digits);
        int asc = Asc(digits);

        int newNumber = desc - asc;
        Console.WriteLine();
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Desc: {desc}");
        Console.WriteLine($"Asc: {asc}");
        Console.WriteLine($"new: {newNumber}");

        counter++; 

        if (newNumber == number) break;
        else number = newNumber;
    } while (true);

    Console.WriteLine();
    Console.WriteLine($"--6174 in {counter} iterations--");

    Console.WriteLine();
    Console.WriteLine("press the any key");
    Console.ReadKey(true);
    Console.Clear();
}
while (true);

IEnumerable<string> Digits(int number) => number.ToString().PadLeft(4, '0').Select(x => x.ToString());

int Desc(IEnumerable<string> digits) => int.Parse(string.Join("", digits.OrderByDescending(x => x)));

int Asc(IEnumerable<string> digits) => int.Parse(string.Join("", digits.OrderBy(x => x)));
