IEnumerable<int> GenerateWithoutYield(int max)
{
    var i = 0;
    var list = new List<int>();
    while (i < max) list.Add(++i);
    return list;
}

IEnumerable<int> GenerateWithYield(int max)
{
    var i = 0;
    while (i < max) yield return ++i;
}

var generatedNumbers = GenerateWithoutYield(1000000000);
foreach (var item in generatedNumbers)
{
    Console.WriteLine(item);
    if (item >= 10) break;
}