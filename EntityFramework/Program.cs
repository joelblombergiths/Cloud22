using EntityFramework.Data;
using EntityFramework.Models;

using EveryLoopContext dbContext = new();

if (!dbContext.Database.CanConnect())
{
    Console.WriteLine("error connecting");
    return;
}

List<Country> countries = dbContext.Countries.ToList();

List<City> cities = dbContext.Cities.ToList();

foreach (Country country in countries)
{
    Console.WriteLine(country.Name);
    
    if (country.Cities == null)
    {
        Console.WriteLine("   -");
        Console.WriteLine();
        continue;
    }

    foreach (City city in country.Cities)
    {
        Console.WriteLine($"   {city.Name}");
    }

    Console.WriteLine();
}


Console.WriteLine();