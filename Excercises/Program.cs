

#pragma warning disable CS8321 // Local function is declared but never used
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Reflection;
using System.Text.RegularExpressions;

// -- Basic --

static void ex1()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Joel Blomberg");
}

static void ex2()
{
    Console.WriteLine(6 + 2);
}

static void ex3()
{
    Console.WriteLine(6 / 2);
}

static void ex4()
{
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine((35 + 5) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
}

static void ex5()
{
    Console.WriteLine("Input first number: ");

    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int tmp = n1;
    n1 = n2;
    n2 = tmp;
    Console.WriteLine($"First number: {n1}");
    Console.WriteLine($"Seccond number: {n2}");
}

static void ex6()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} * {n2} * {n3} = {n1 * n2 * n3}");

}

static void ex7()
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

static void ex8()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 1; i <=10; i++)
    {
        Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

static void ex9()
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

static void ex10()
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

static void ex11()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"You look older than {n}");
}

static void ex12()
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

static void ex13()
{
    Console.WriteLine("Input number of rows: ");
    int numRows = int.Parse(Console.ReadLine());

    for (int row = 0; row < numRows; row++)
    {
        switch (row)
        {
            case 0:
            case int _ when row == numRows -1: Console.WriteLine($"{numRows}{numRows}{numRows}"); break;
            default: Console.WriteLine($"{numRows} {numRows}"); break;
        }
    }
}


static void ex14()
{
    Console.WriteLine("Input degrees in Celsius: ");
    int celsius = int.Parse(Console.ReadLine());

    float farenheit = (celsius * 9 / 5) + 32;
    float kelvin = celsius + 273.15f;

    Console.WriteLine($"{celsius}°C is:");
    Console.WriteLine($"{farenheit}°F");
    Console.WriteLine($"{kelvin}°K");
}

static void ex15()
{
    string org = "w3resource";
    Console.WriteLine($"Original string \"{org}\"");
    Console.WriteLine($"index 1 removed: {org.Remove(1, 1)}");
    Console.WriteLine($"index 9 removed: {org.Remove(9, 1)}");
    Console.WriteLine($"index 0 removed: {org.Remove(0, 1)}");
}

static void ex16()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();


    string newText = text.Length > 1 ? $"{text[^1]}{text[1..^1]}{text[0]}" : text;
    Console.WriteLine($"New text: {newText}");
}

static void ex17()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string newText = !string.IsNullOrEmpty(text) ? $"{text[0]}{text}{text[0]}" : text;
    Console.WriteLine($"New text: {newText}");
}

static void ex18()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if ((n1 >= 0 && n2 < 0) || (n2 >= 0 && n1 < 0)) match = true;

    Console.WriteLine(match);
}

static void ex19()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    if (n1 == n2) sum *= 3;

    Console.WriteLine(sum);
}

static void ex20()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int value = Math.Abs(n1 - n2);
    if (n1 > n2) value *= 2;

    Console.WriteLine(value);
}

static void ex21()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    bool match = false;

    if (sum == 20 || n1 == 20 || n2 == 20) match = true;

    Console.WriteLine(match);
}

static void ex22()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (Math.Abs(100 - n) <= 20 || Math.Abs(200 - n) <= 20) match = true;

    Console.WriteLine(match);
}

static void ex23()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine($"Lowercase: {text.ToLower()}");
}

static void ex24()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string[] words = text.Split(' ');

    Console.WriteLine($"Longest word is: {words.OrderBy(x => x.Length).Last()}");
}

static void ex25()
{
    for(int i = 0; i < 100; i++)
    {
        if (i % 2 != 0) Console.WriteLine(i);
    }
}

static void ex26()
{
    List<int> primeNumbers = new();

    int counter = 2;
    do
    {
        bool match = true;        
        for (int i = 2; i < counter; i++)
        {
            if (counter % i == 0)
            {
                match = false; 
                break;
            }
        }
        if (match) primeNumbers.Add(counter);
        
        counter++;
    }
    while (primeNumbers.Count < 500);
    Console.WriteLine(string.Join("\n",primeNumbers));
    Console.WriteLine($"Sum of first 500 prime numbers: {primeNumbers.Sum()}");
}

static void ex27()
{
    Console.WriteLine("Input number: ");
    string text = Console.ReadLine();

    int sum = text.ToArray().Select(x => int.Parse(x.ToString())).Sum();
    Console.WriteLine($"The sum of the digits in {text} is {sum}");
}

static void ex28()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string reversed = string.Join(" ", text.Split(' ').Reverse());
    Console.WriteLine(reversed);
}

static void ex29()
{
    Console.WriteLine("Input path to file: ");
    string text = Console.ReadLine();
    FileInfo fi = new(text);

    if (fi.Exists) Console.WriteLine($"Size: {fi.Length}");
    else Console.WriteLine("File does not exist");
}

static void ex30()
{
    Console.WriteLine("Input HEX: ");
    string hex = Console.ReadLine();

    int dec = Convert.ToInt32(hex, 16);
    Console.WriteLine(dec);
}

static void ex31()
{
    int[] a1 = { 1, 3, -5, 4 };
    int[] a2 = { 1, 4, -5, -2 };

    for(int i = 0; i < a1.Length; i++)
    {
        Console.Write($"{a1[i] * a2[i]} ");
    }    
}

static void ex32()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result = text.Length < 4 ? text : string.Format("{0}{0}{0}{0}", text[^4..^0]);
    Console.WriteLine(result);
}

static void ex33()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (n > 0 && (n % 3 == 0 || n % 7 == 0)) match = true;

    Console.WriteLine(match);
}

static void ex34()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    bool match = false; 
    if (text.StartsWith("Hello")) match = true;

    Console.WriteLine(match);
}

static void ex35()
{
    Console.WriteLine("Input number < 100: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input number > 200: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n1 < 100 && n2 > 200) match = true;   

    Console.WriteLine(match);
}

static void ex36()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if((n1 >= -10 && n1 <= 10) || (n2 >= -10 && n2 <= 10)) match = true;

    Console.WriteLine(match);
}

static void ex37()
{
    string text = "PHP Tutorial";

    string result;
    if (text.Substring(1, 2).Equals("HP")) result = text.Replace("HP", string.Empty);
    else result = text;

    Console.WriteLine(result);
}

static void ex38()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine().ToUpper();

    if (text[0] == 'P' && text[1] == 'H') Console.WriteLine($"{text[0]}{text[1]}");
}

static void ex39()
{
    List<int> numbers = new();
    Console.WriteLine("Input first number: ");
    numbers.Add(int.Parse(Console.ReadLine()));
    Console.WriteLine("Input seccond number: ");
    numbers.Add(int.Parse(Console.ReadLine()));
    Console.WriteLine("Input third number: ");
    numbers.Add(int.Parse(Console.ReadLine()));

    numbers = numbers.OrderBy(x => x).ToList();
    Console.WriteLine($"Lowest: {numbers.First()}");
    Console.WriteLine($"Highest: {numbers.Last()}");
}

static void ex40()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int result;
    int n1Diff = Math.Abs(20 - n1);
    int n2Diff = Math.Abs(20 - n2);
    if (n1Diff == n2Diff) result = 0;
    else result = n1Diff < n2Diff ? n1 : n2;

    Console.WriteLine(result);
}

static void ex41()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int countW = text.Where(x => x.Equals('w')).Count();

    bool match = false;
    if (countW >= 1 && countW <= 3) match = true;

    Console.WriteLine(match);
}

static void ex42()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result;
    if (text.Length < 4) result = text.ToUpper();
    else result = $"{text[0..3].ToLower()}{text[4..^0]}";

    Console.WriteLine(result);
}

static void ex43()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    bool match = false;
    if(text.StartsWith('w'))
    {
        if(text.Substring(1,2) == "ww" && text.Substring(1, 2) == "ww") match = true;
    }

    Console.WriteLine(match);
}

static void ex44()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    for (int i = 0; i < text.Length; i++)
    {
        if (i % 2 == 0) Console.Write(text[i]);
    }
}

static void ex45()
{
    List<int> list = new();
    for(int i = 0; i < 100; i++)
    {
        list.Add(Random.Shared.Next(1, 10));
    }
    
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    int count = list.Where(x => x.Equals(n)).Count();
    Console.WriteLine($"{n} occurs {count} times");
}

static void ex46()
{
    List<int> list = new();
    for (int i = 0; i < 100; i++)
    {
        list.Add(Random.Shared.Next(1, 10));
    }

    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (list.Any() && (list.First().Equals(n) || list.Last().Equals(n))) match = true;

    Console.WriteLine(match);
}

static void ex47()
{
    List<int> list = new();
    for (int i = 0; i < 100; i++)
    {
        list.Add(Random.Shared.Next(1, 10));
    }

    Console.WriteLine(list.Sum());
}

static void ex48()
{
    List<int> list = new();
    for (int i = 0; i < 100; i++)
    {
        list.Add(Random.Shared.Next(1, 10));
    }   

    bool match = false;
    if (list.Any() && list.First().Equals(list.Last())) match = true;

    Console.WriteLine(match);
}

static void ex49()
{
    List<int> list = new();
    for (int i = 0; i < 100; i++)
    {
        list.Add(Random.Shared.Next(1, 10));
    }

    List<int> list2 = new();
    for (int i = 0; i < 100; i++)
    {
        list2.Add(Random.Shared.Next(1, 10));
    }

    bool match = false;
    if (list.Any())
    { 
        if(list.First().Equals(list2.First())) match = true;
        else if (list.Last().Equals(list2.Last())) match = true;
        else match = false;
    }

    Console.WriteLine(match);
}

static void ex50()
{
    int[] a = new[] { 1, 2, 8 };
    Console.WriteLine(string.Join(" ", a));
    Console.WriteLine(string.Join(" ", a.Prepend(a[^1]).SkipLast(1)));    
}

static void ex51()
{
    List<int> list = new();
    for (int i = 0; i < 10; i++)
    {
        list.Add(Random.Shared.Next(1, 100));
    }

    Console.WriteLine(string.Join(" ", list));
    int largest = list.OrderBy(x => x).Last();


    Console.WriteLine(largest);
}

static void ex52()
{
    int[] a1 = new[] { 1, 2, 5 };
    int[] a2 = new[] { 0, 3, 8 };
    int[] a3 = new[] { -1, 3, 0 };

    int[] newA = { a1[2], a2[2], a3[2] };

    Console.WriteLine(string.Join(" ", newA));
}

static void ex53()
{
    List<int> list = new();
    for (int i = 0; i < 10; i++)
    {
        list.Add(Random.Shared.Next(1, 100));
    }

    Console.WriteLine(string.Join(" ", list));

    Console.WriteLine(list.Any(x => x % 2 != 0));
}

static void ex54()
{
    Console.WriteLine("Input year: ");
    string year = Console.ReadLine();

    Console.WriteLine(year[0..2]);
}

static void ex55()
{
   //full retard
}

static void ex56()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    bool match = false;
    if (text.Equals(string.Join("", text.Reverse().ToArray()))) match = true;

    Console.WriteLine(match);
}

static void ex57()
{
    List<int> list = new();
    for (int i = 0; i < 10; i++)
    {
        list.Add(Random.Shared.Next(1, 100));
    }

    int max = int.MinValue;
    (int, int) pair = new();
    for (int i = 0; i < list.Count - 1; i++)
    {
        int sum = list[i] * list[i + 1];
        if (sum > max)
        {
            max = sum;
            pair = (list[i], list[i + 1]);
        }
    }

    Console.WriteLine($"{pair.Item1} and {pair.Item2} has the largest sum of {max}");
}

static void ex58()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    list.Sort();    
    int missing = (list.Last() - list.First() - list.Count) + 1;

    Console.WriteLine(missing); 
}

static void ex59()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    list.Sort();

    bool match = true;
    for (int i = 0; i < list.Count -2; i++)
    {
        if (list[i] == list[i + 1])
        {
            match = false;
            break;
        }
    }

    Console.WriteLine(match);
}

static void ex60()
{
    int[,] matrix = new int[3, 4] { { 0, 2, 3, 2 }, { 0, 6, 0, 1 }, { 4, 0, 3, 0 } };
            
    List<int> eligibleValues = new();
    for (int x = 0; x < 3; x++)
    {        
        for (int y = 0; y < 4; y++)
        {
            if (x > 0 && matrix[x - 1, y] == 0) Console.Write("X ");
            else
            {
                Console.Write($"{matrix[x, y]} ");

                if (matrix[x,y] != 0) eligibleValues.Add(matrix[x, y]);
            }
        }
        Console.WriteLine();
    }
    
    Console.WriteLine($"sum of {string.Join(" + ", eligibleValues)} = {eligibleValues.Sum()}");
}

static void ex61()
{
    int[] list = new[] { 5, 3, 1, -5, 9 };
    Console.WriteLine(string.Join(" ", list));
    

    int[] sort = list.Where(x => x != -5).OrderBy(x => x).ToArray();

    int i = 0;
    int[] sorted = list.Select(x => x != -5 ? list[i++] : -5).ToArray();

    Console.WriteLine(string.Join(" ", sorted));
}

static void ex62()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    do
    {
        int start = text.IndexOf('(');
        if (start == -1) break;

        int end = text.IndexOf(')');
        if (end == -1) break;

        string part = text[(start + 1)..end];
        Console.WriteLine(string.Join(" ", part.Split(' ').Reverse()));
        text = text.Remove(start, end - start + 1);
    } while (true);
}

static void ex63()
{
    List<int> list = new();
    for (int i = 0; i < 10; i++)
    {
        list.Add(Random.Shared.Next(1, 100));
    }
    
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    if (list.Contains(n)) Console.WriteLine("Exists");
    else Console.WriteLine("Doesn't exists");
}

static void ex64()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    FileInfo fi = new(text);

    Console.WriteLine($"Filename: {fi.Name}");
}

static void ex65()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    Console.WriteLine(string.Join(",", list.Select(x => x * list.Count)));
}

static void ex66()
{
    string n1 = "3";
    string n2 = "7";

    if (int.Parse(n1) < int.Parse(n2)) Console.WriteLine($"{n1} is the smallest number");
    else Console.WriteLine($"{n2} is the smallest number");
}

static void ex67()
{
    // 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.

    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result = text.Replace('P', '9').Replace('T', '0').Replace('S', '1').Replace('H', '6').Replace('A', '8');

    Console.WriteLine(result);
}

static void ex68()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Input character: ");
    string c = Console.ReadLine().ToLower();

    Console.WriteLine(text.ToLower().Count(x => x.Equals(c[0])));
}

static void ex69()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if(text.All(x => char.IsUpper(x))) Console.WriteLine("All Uppercase");
    else if (text.All(x => char.IsLower(x))) Console.WriteLine("All Lowercase");
    else Console.WriteLine("Mixed cases");
}

static void ex70()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine(text[1..^1]);
}

static void ex71()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    bool match = false;
    for (int i = 0; i < text.Length -1; i++)
    {
        if (char.ToLower(text[i]).Equals(char.ToLower(text[i+1])))
        {
            match = true;
            break;
        }
    }

    Console.WriteLine(match);
}

static void ex72()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    if (list.Average() % 1 == 0) Console.WriteLine("Avg is int");
    else Console.WriteLine("Avg is decimal");
}

static void ex73()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result = string.Join("", text.ToArray().OrderBy(x => x));

    Console.WriteLine(result);
}

static void ex74()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result = text.Length % 2 == 0 ? "Even" : "Odd";

    Console.WriteLine($"length is {result}");
}

static void ex75()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"the {n} odd number is {2 * n - 1}");
}

static void ex76()
{
    Console.WriteLine("Input character: ");
    string text = Console.ReadLine();

    Console.WriteLine($"ASCII for {text} is {(int)text[0]}");
}

static void ex77()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine($"{text} is plural? {text.EndsWith("s")}");
}

static void ex78()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    double sum = 0;
    list.ForEach(x => sum += Math.Sqrt(x));

    Console.WriteLine(sum);
}

static void ex79()
{
    string s1 = "7";
    Console.WriteLine($"value: {s1} type: {s1.GetType()}");
    int i1 = int.Parse(s1);
    Console.WriteLine($"value: {i1} type: {i1.GetType()}");
    
    Console.WriteLine("-");
    
    int i2 = 3;
    Console.WriteLine($"value: {i2} type: {i2.GetType()}");
    string s2 = i2.ToString();
    Console.WriteLine($"value: {s2} type: {s2.GetType()}");
}

static void ex80()
{
    object[] list = new object[] { 7, "Bear", true, DateTime.Now, 13.6f };

    foreach (object obj in list)
    {
        Console.WriteLine($"value: {obj} type: {obj.GetType()}");
    }

    Console.WriteLine("-");

    foreach (object obj in list)
    {
        string s = obj.ToString();
        Console.WriteLine($"value: {s} type: {s.GetType()}");
    }
}

static void ex81()
{
    Console.WriteLine("Input number: ");
    string text = Console.ReadLine();
    if(text.Length != 2) return;

    int reversed = int.Parse(string.Join("", text.ToArray().Reverse()));

    Console.WriteLine(reversed < int.Parse(text));
}

static void ex82()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine(Regex.Replace(text, @"[^A-Za-z]", string.Empty));
}

static void ex83()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine(Regex.Replace(text, @"[AOUEI]", string.Empty));
}

static void ex84()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();
    
    for (int i = 0; i < text.Length; i++)
    {
        if (char.IsLower(text[i])) Console.Write($"{i} ");
    }    
}

static void ex85()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    
    for (int i = 0; i < list.Count; i++)
    {
        int sum = 0;
        for (int j = 0; j <= i; j++)
        {
            sum += list[j];            
        }
        Console.Write($"{sum} ");
    }
}

static void ex86()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int numLetter = text.Count(x => char.IsLetter(x));
    int numDigits = text.Count(x => char.IsDigit(x));

    Console.WriteLine($"Num letters: {numLetter}, Num digits: {numDigits}");
}

static void ex87()
{
    bool b = true;
    Console.WriteLine($"org value {b}");
    Console.WriteLine($"reverse value {!b}");
}

static void ex88()
{
    // (n-2) x 180
    Console.WriteLine("Input number of lines: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Interior angle is {(n-2) * 180}");
}

static void ex89()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));
    
    int numNegatives = list.Count(x => x < 0);
    int numPositives = list.Count(x => x >= 0);

    Console.WriteLine($"Negatives: {numNegatives}");
    Console.WriteLine($"Positives: {numPositives}");
}

static void ex90()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    string binary = Convert.ToString(n, 2);
    Console.WriteLine(binary);

    int numOnes = binary.Count(x => x.Equals('1'));
    int numZeros = binary.Count(x => x.Equals('0'));

    Console.WriteLine($"Ones: {numOnes}");
    Console.WriteLine($"Zeros: {numZeros}");
}

static void ex91()
{
    object[] list = new object[] { 7, "Bear", true, DateTime.Now, 13.6f };

    Console.WriteLine(string.Join("",list.Where(x => x is int)));
}

static void ex92()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    int pn = 0;
    int counter = n + 1;
    bool isPrime;
    
    do
    {
        isPrime = true;
        for (int i = 2; i < counter; i++)
        {
            if (counter % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime) pn = counter;
        else counter++;
    }
    while (!isPrime);

    Console.WriteLine($"Next prime: {pn}");
}

static void ex93()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());
           
    int counter = 0;
    do
    {
        counter++;
    }
    while (counter * counter < n);

    int sqrt;
    if (counter * counter == n) sqrt = counter;
    else sqrt = counter - 1;

    Console.WriteLine($"sqrt({n}) = {sqrt}");
}

static void ex94()
{
    List<string> list = new() { "Bort", "Whang", "Yarder", "Zoonic" };

    list = list.OrderBy(s => s.Length).ToList();

    string prefix = string.Empty;
    for(int i = 0; i < list.First().Length; i++)
    {
        string c = list.First().Substring(i, 1);
        if (list.All(s => s.Substring(i, 1).Equals(c))) prefix += c;
        else break;
    }
    Console.WriteLine($"\"{prefix}\"");
}

static void ex95()
{
    static bool checkRec(string s, string s2 = "")
    {
        if (s.Length == 0)
        {
            if (s2.Length > 0) return checkRec(s2);
            else return true;
        }

        char opposite = s[0] switch
        {
            '{' => '}',
            '(' => ')',
            '[' => ']',
            '<' => '>',
            _ => char.MinValue
        };

        int closeIndex = s.LastIndexOf(opposite);

        if (closeIndex < 0) return false;
        else return checkRec(s[1..closeIndex], s[(closeIndex + 1)..^0]);
    }

    string text = "[<>()[]{}]";

    Console.WriteLine(checkRec(text));    
}


// -- Basic Algorithms --

static void b1()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    if (n1 == n2) sum *= 3;

    Console.WriteLine(sum);
}

static void b2()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    int diff = Math.Abs(n - 51);
    if (n > 51) diff *= 3;

    Console.WriteLine(diff);
}

static void b3()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n1 > 30 || n2 > 30 || n1 + n2 > 30) match = true;

    Console.WriteLine(match);
}

static void b4()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10) match = true;

    Console.WriteLine(match);
}

static void b5()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if (!text.StartsWith("if")) text = $"if {text}";

    Console.WriteLine(text);
}

static void b6()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Input index: ");
    int n = int.Parse(Console.ReadLine());

    if (n < 0 || n >= text.Length) Console.WriteLine("Index out of bounds");
    else Console.WriteLine(text.Remove(n, 1));
}

static void b7()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string newText = text.Length > 1 ? $"{text[^1]}{text[1..^1]}{text[0]}" : text;
    Console.WriteLine(newText);
}

static void b8()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if (text.Length < 2) Console.WriteLine(text);
    else Console.WriteLine("{0}{0}{0}{0}",text[..2]);
}

static void b9()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string newText = !string.IsNullOrEmpty(text) ? $"{text[^1]}{text}{text[^1]}" : text;
    Console.WriteLine($"New text: {newText}");
}

static void b10()
{
    Console.WriteLine("Input index: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (n >= 0 && (n % 3 == 0 || n % 7 == 0)) match = true;

    Console.WriteLine(match);
}

static void b11()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if (text.Length < 3) Console.WriteLine("{0}{0}{0}", text);
    else Console.WriteLine($"{text[..3]}{text}{text[..3]}");
}

static void b12()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine(text.StartsWith("C#"));
}

static void b13()
{
    Console.WriteLine("Input first temperature: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond temperature: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n1 < 0 && n2 > 100) match = true;

    Console.WriteLine(match);
}

static void b14()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if (Enumerable.Range(100, 201).Contains(n1) || Enumerable.Range(100, 201).Contains(n2)) match = true;

    Console.WriteLine(match);
}

static void b15()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    List<bool> match = new()
    {
        Enumerable.Range(20, 51).Contains(n1),
        Enumerable.Range(20, 51).Contains(n2),
        Enumerable.Range(20, 51).Contains(n3)
    };

    Console.WriteLine(match.Any(x => x));
}

static void b16()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());
        
    //Console.WriteLine($"n1 <= 20: {n1 <= 20}");
    //Console.WriteLine($"n2 >= 50: {n2 >= 50}");
    //Console.WriteLine($"(n1 <= 20 || n2 >= 50): {(n1 <= 20 || n2 >= 50)}");
    //Console.WriteLine($"n2 <= 20: {n2 <= 20}");
    //Console.WriteLine($"n1 >= 50: {n1 >= 50}");
    //Console.WriteLine($"(n2 <= 20 || n1 >= 50): {(n2 <= 20 || n1 >= 50)}");
    //Console.WriteLine($"(n1 <= 20 || n2 >= 50) || (n2 <= 20 || n1 >= 50): {(n1 <= 20 || n2 >= 50) || (n2 <= 20 || n1 >= 50)}");

    bool match = false;
    if ((n1 >= 20 && n1 <= 50) ^ (n2 >= 20 && n2 <= 50)) match = true;    
    Console.WriteLine(match);
}

static void b17()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if (text[1..].StartsWith("yt")) Console.WriteLine(text.Replace("yt", string.Empty));
    else Console.WriteLine(text);
}

static void b18()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    int max = n1;
    if (n2 > max) max = n2;
    if (n3 > max) max = n3;

    Console.WriteLine(max);
}

static void b19()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int n1Diff = Math.Abs(100 - n1);
    int n2Diff = Math.Abs(100 - n2);

    int nearest;
    if (n1Diff == n2Diff) nearest = 0;
    else nearest = n1Diff > n2Diff ? n1Diff : n2Diff;

    Console.WriteLine(nearest);
}

static void b22()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int countY = text.ToArray().Count(x => x.Equals('y'));

    bool match = false;
    if (countY >= 2 && countY <= 4) match = true;

    Console.WriteLine(match);
}

static void b23()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if ((n1 % 10) == (n2 % 10)) match = true;

    Console.WriteLine(match);
}

static void b24()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    if (text.Length < 3) Console.WriteLine(text.ToUpper());
    else Console.WriteLine($"{text[..^3]}{text[^3..].ToUpper()}");
}

static void b25()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Input count: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 0; i < n; i++)
    {
        Console.Write(text);
    }
}

static void b26()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Input count: ");
    int n = int.Parse(Console.ReadLine());

    string newString;
    if (text.Length < 3) newString = text;
    else newString = $"{text[..^3]}{text[^3..].ToUpper()}";

    for (int i = 0; i < n; i++)
    {
        Console.Write(newString);
    }
}

static void b27()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int count = 0;
    for (int i = 0; i < text.Length - 1; i++)
    {
        if (text[i] == 'a' && text[i + 1] == 'a') count++;
    }

    Console.WriteLine(count);
}

static void b28()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int firstA = text.IndexOf('a');

    bool match = false;
    if (text[firstA + 1] == 'a') match = true;

    Console.WriteLine(match);
}

static void b29()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    for (int i = 0; i < text.Length; i += 2)
    {
        Console.Write(text[i]);
    }
}

static void b30()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    for (int i = 1; i <= text.Length; i++)
    {
        Console.Write(text[0..i]);
    }
}

static void b31()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    
    int count = 0;
    if (text.Length > 1)
    {
        string s = text[^2..];

        for (int i = 0; i < text.Length - 2; i++)
        {
            if (text[i..(i + 2)] == s) count++;
        }
    }
    Console.WriteLine(count);
}

static void b32()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    Console.WriteLine("Input search value: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (list.Contains(n)) match = true;

    Console.WriteLine(match);
}

static void b33()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    Console.WriteLine("Input search value: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (list.Take(4).Contains(n)) match = true;

    Console.WriteLine(match);
}

static void b34()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    bool match = false;
    for (int i = 0; i < list.Count - 2; i++)
    {
        if (list[i] == 1 && list[i + 1] == 2 && list[i + 2] == 3)
        {
            match = true;
            break;
        }
    }

    Console.WriteLine(match);
}

static void b35()
{
    Console.WriteLine("Input first text: ");
    string text1 = Console.ReadLine();

    Console.WriteLine("Input second text: ");
    string text2 = Console.ReadLine();

    List<string> values = new() {text1, text2 };
    values = values.OrderBy(x => x.Length).ToList();

    int count = 0;
    for (int i = 0; i < values.First().Length; i += 2)
    {
        string s = values.First().Substring(i, 2);

        for (int j = 0; j < values.Last().Length; j += 2)
        {
            if (values.Last().Substring(j, 2).Equals(s)) count++;
        }
    }

    Console.WriteLine(count);
}

static void b36()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    Console.WriteLine("Input character to remove: ");
    string remove = Console.ReadLine();

    Console.Write(text[0]);
    foreach (char c in text[1..^1])
    {
        if (c != remove[0]) Console.Write(c);
    }
    Console.Write(text[^1]);
}

static void b37()
{
    //Sämst skriven fråga so far...

    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    int counter = 0;
    
    while(counter < text.Length - 1)
    {
        Console.Write($"{text[counter]}{text[counter + 1]}");
        counter += 4;
    }
}


static void b38()
{
    // "Also count the situation where the second 5 is actually a 6" ;-D

    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    int count = 0;
    for (int i = 0; i < list.Count - 1; i++)
    {
        if (list[i] == 5 && (list[i + 1] == 5 || list[i + 1] == 6)) count++;
    }

    Console.WriteLine(count);
}

static void b39()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    bool match = false;
    for (int i = 0; i < list.Count - 2; i++)
    {
        if (list[i + 1] == list[i] && list[i + 2] == list[i]) match = true;
    }

    Console.WriteLine(match);
}

static void b40()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;
    if (sum >= 10 || sum <= 30) sum = 30;

    Console.WriteLine(sum);
}

static void b41()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n1 == 5 || n2 == 5 || n1 + n2 == 5 || Math.Abs(n1 - n2) == 5) match = true;

    Console.WriteLine(match);
}

static void b42()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (n % 13 <= 1) match = true;

    Console.WriteLine(match);
}

static void b43()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (n % 3 == 0 ^ n % 7 == 0) match = true;

    Console.WriteLine(match);
}

static void b44()
{
    Console.WriteLine("Input number: ");
    int n = int.Parse(Console.ReadLine());

    bool match = false;
    if (n % 10 <= 2) match = true;

    Console.WriteLine(match);
}

static void b45()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;

    if ((n1 >= 10 && n1 <= 20) || (n2 >= 10 && n2 <= 20)) sum = 18;

    Console.WriteLine(sum);
}

static void b46()
{
    Console.WriteLine("Input text: ");
    string text = Console.ReadLine();

    string result = string.Empty;

    if (text.StartsWith("F")) result = "Fizz";
    if (text.EndsWith("B")) result += "Buzz";

    if (string.IsNullOrEmpty(result)) result = text;

    Console.WriteLine(result);
}

static void b47()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n1 + n2 == n3) match = true;

    Console.WriteLine(match);
}

static void b48()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    bool match = false;
    if (n2 > n1 && n3 > n2) match = true;

    Console.WriteLine(match);
}

static void b49()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Allow equals (yes/no): ");
    bool eq = Console.ReadLine().ToLower().Equals("yes");
    
    bool match = false;
    if (eq)
    {
        if (n1 <= n2 && n2 <= n3) match = true;
    }
    else
    {
        if (n1 < n2 && n2 < n3) match = true;
    }

    Console.WriteLine(match);
}

static void b50()
{
    Console.WriteLine("Input list (separated by comma): ");
    string text = Console.ReadLine();

    List<int> list = new();
    list.AddRange(text.Split(',').Select(x => int.Parse(x)));

    bool match = false;
    int lastDigit = list[0] % 10;
    list.ForEach(x => match = x % 10 == lastDigit);

    Console.WriteLine(match);
}

static void b51()
{
    //words are hard...
}

static void b52()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int result;
    if (n1 == n2) result = 0;
    else
    {
        List<int> numbers = new() { n1, n2 };
        numbers.Sort();

        if (numbers[0] % 7 == numbers[1] % 7) result = numbers.First();
        else result = numbers.Last();
    }

    Console.WriteLine(result);
}

static void b53()
{
    Console.WriteLine("Input first number: ");
    string n1 = Console.ReadLine();

    Console.WriteLine("Input seccond number: ");
    string n2 = Console.ReadLine();

    bool match = n1.ToArray().Intersect(n2.ToArray()).Any();

    Console.WriteLine(match);
}

static void b54()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int sum = n1 + n2;

    if (sum.ToString().Length > n1.ToString().Length) sum = n1;

    Console.WriteLine(sum);
}

static void b55()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    int sum;
    if (n1 == n2) sum = n3;
    else sum = n1 + n2 + n3;

    Console.WriteLine(sum);
}

static void b56()
{
    //retard
}

static void b57()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int n3 = int.Parse(Console.ReadLine());

    if (n1 >= 10 && n1 <= 20 && n1 != 13 && n1 != 17) n1 = 0;    
    if (n2 >= 10 && n2 <= 20 && n2 != 13 && n2 != 17) n2 = 0;
    if (n3 >= 10 && n3 <= 20 && n3 != 13 && n3 != 17) n3 = 0;

    int sum = n1 + n2 + n3;

    Console.WriteLine(sum);
}

static void b58()
{
    Console.WriteLine("Input first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int n2 = int.Parse(Console.ReadLine());

    int result;
    if (n1 > 13 && n2 > 13) result = 0;
    else
    {
        int n1Diff = Math.Abs(13 - n1);
        int n2Diff = Math.Abs(13 - n2);

        if (n1Diff < n2Diff) result = n1;
        else result = n2;
    }

    Console.WriteLine(result);
}

static void b59()
{
    Console.WriteLine("Input first number: ");
    int small = int.Parse(Console.ReadLine());

    Console.WriteLine("Input seccond number: ");
    int medium = int.Parse(Console.ReadLine());

    Console.WriteLine("Input third number: ");
    int large = int.Parse(Console.ReadLine());

    int smallDiff = Math.Abs(small - medium);
    int largeDiff = Math.Abs(medium - large);

    Console.WriteLine(smallDiff == largeDiff);
}

static void b60()
{
    Console.WriteLine("Input first text: ");
    string s1 = Console.ReadLine();

    Console.WriteLine("Input second text: ");
    string s2 = Console.ReadLine();

    string newString = $"{s1}{s2}{s2}{s1}";

    Console.WriteLine(newString);
}

static void b61()
{

}

while (true)
{
    b59();
    Console.ReadKey();
}