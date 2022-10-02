using System.Text;
using v39mon;
using System.Linq;
using System.Collections.Generic;
using System;

/* Uppg 109

Number number = new(100);

number.Value++;
number.Value++;

Console.WriteLine(string.Join(",", number.GetHistory ));
*/

/*Uppg 110

Text t1 = Text.Create("abc");
Text t2 = Text.Create("defghi");

Console.WriteLine(Text.TotalLengthOfAllInstances);
Console.WriteLine(Text.AverageLengthOfAllInstances);
*/

Console.WriteLine(Persistence(25));
Console.WriteLine();
int Persistence(long n)
{
    if (n < 10) return 0;

    int count = 0;

    while (n / 10 >= 1)
    {
        int pow = 0;
        for (long i = 1; i < (long)Math.Pow(10, 18); i *= 10)
        {
            if (n / i > 10) pow++;
            else break;
        }

        long product = 1;
        long temp = n;
        for (int i = pow; i >= 0; i--)
        {            
            product *= temp / (long)Math.Pow(10, i);
            temp %= (long)Math.Pow(10, i);

        }

        n = product;
        count++;
    }

    if (n == 10) count++;

    return count;
}














/*--- Code Wars ---
 

string DuplicateEncode(string word)
{
    StringBuilder sb = new();

    for (int i = 0; i < word.Length; i++)
    {
        char current = char.ToLower(word[i]);

        if (word.Count(x => char.ToLower(x) == current) > 1) sb.Append(")");
        else sb.Append("(");
    }

    return sb.ToString();
}

string AlphabetPosition(string text)
{
    List<int> list = new();

    for (int i = 0; i < text.Length; i++)
    {
        char current = text[i];

        if (char.IsLetter(current))
        {
            list.Add((char.ToLower(current) - 'a') + 1);
        }
    }
    return string.Join(" ", list);
}

string ToCamelCase(string str)
{
    string[] words = str.Split('_', '-');

    StringBuilder sb = new();

    if(words.Length > 0)
    {
        sb.Append(words[0]);

        for (int i = 1; i < words.Length; i++)
        {
            string current = words[i];

            sb.Append($"{char.ToUpper(current[0])}{current[1..^0]}");
        }
    }

    return sb.ToString();
}

string Rgb(int r, int g, int b)
{    
    return $"{Math.Clamp(r, 0, 255):X2}{Math.Clamp(g, 0, 255):X2}{Math.Clamp(b, 0, 255):X2}".ToUpper();
}

static string ExpandedForm(long num)
{
    List<string> list = new();

    for (long i = (long)Math.Pow(10, 18); i > 0; i /= 10)
    {
        if (num / i > 0)
        {
            list.Add($"{(num / i) * i}");
            num %= i;
        }
    }

    return string.Join(" + ", list);
}


static int DuplicateCount(string str)
{
    int count = 0;
    for (char c = 'a'; c <= 'z'; c++)
    {
        if (str.Count(x => c == char.ToLower(x)) > 1) count++;
    }

    for (char c = '0'; c <= '9'; c++)
    {
        if (str.Count(x => c == char.ToLower(x)) > 1) count++;
    }


    return count;
}

*/