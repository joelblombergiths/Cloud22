
RomanToInt("MCMLXXXIV");

int RomanToInt(string s)
{
    char[] letters = s.ToCharArray();
    List<string> explanations = new();
    int sum = 0;

    for (int i = 0; i < letters.Length; i++)
    {
        if (i + 1 < letters.Length)
        {
            bool isSubtraction = false;
            char letter = letters[i];
            char next = letters[i + 1];

            switch (letter)
            {
                case 'C':
                    switch (next)
                    {
                        case 'M':
                            sum += 900;
                            explanations.Add($"{letter}{next} = 900");
                            i++;
                            isSubtraction = true;
                            break;
                        case 'D':
                            sum += 400;
                            explanations.Add($"{letter}{next} = 400");
                            i++;
                            isSubtraction = true;
                            break;
                    }
                    break;
                case 'X':
                    switch (next)
                    {
                        case 'C':
                            sum += 90;
                            explanations.Add($"{letter}{next} = 90");
                            i++;
                            isSubtraction = true;
                            break;
                        case 'L':
                            sum += 40;
                            explanations.Add($"{letter}{next} = 40");
                            i++;
                            isSubtraction = true;
                            break;
                    }
                    break;
                case 'I':
                    switch (next)
                    {
                        case 'X':
                            sum += 9;
                            explanations.Add($"{letter}{next} = 9");
                            i++;
                            isSubtraction = true;
                            break;
                        case 'V':
                            sum += 4;
                            explanations.Add($"{letter}{next} = 4");
                            i++;
                            isSubtraction = true;
                            break;
                    }
                    break;
            }

            if (isSubtraction) continue;
        }

        char[] n = letters.Skip(i).TakeWhile(l => l == letters[i]).ToArray();

        int number = 0;
        switch (n.First())
        {
            case 'M':
                number = 1000 * n.Length;
                break;
            case 'D':
                number = 500 * n.Length;
                break;
            case 'C':
                number = 100 * n.Length;
                break;
            case 'L':
                number = 50 * n.Length;
                break;
            case 'X':
                number = 10 * n.Length;
                break;
            case 'V':
                number = 5 * n.Length;
                break;
            case 'I':
                number = 1 * n.Length;
                break;
            default: Console.WriteLine("fail"); break;
        }

        explanations.Add($"{string.Join("", n)} = {number}");
        sum += number;
        if (n.Length > 1) i += n.Length - 1;
    }

    Console.WriteLine(sum);
    Console.WriteLine(string.Join(", ", explanations));
    return sum;
}