using System.Data;
using Microsoft.Data.SqlClient;

string conString = "server=localhost;database=everyloop;trusted_connection=true;TrustServerCertificate=true";
string query = "select number,symbol,name from elements where period = 2";

SqlConnection con = new(conString);
con.Open();

while (true)
{
    Console.Write("Enter Search string: ");
    string? searchString = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(searchString)) break;
    FetchAirports(con, searchString);
}


static void FetchAirports(SqlConnection connection, string searchString)
{
    try
    {
        string query =
            "select top 5 Iata,[Airport Name], [Location Served] from Airports where [Airport name] like '%' + @searchString + '%'";
        Console.WriteLine(query);
        Console.WriteLine();

        using SqlCommand cmd = new(query, connection);
        cmd.Parameters.Add("searchString", SqlDbType.NVarChar).Value = searchString;

        using SqlDataReader reader = cmd.ExecuteReader();

        Console.Write(reader.GetName(0).PadRight(10).ToUpper());
        Console.Write(reader.GetName(1).PadRight(50).ToUpper());
        Console.Write(reader.GetName(2).PadRight(50).ToUpper());
        Console.WriteLine();


        while (reader.Read())
        {
            Console.Write(reader.GetValue(0).ToString().PadRight(10));
            Console.Write(reader.GetValue(1).ToString().PadRight(50));
            Console.Write(reader.GetValue(2).ToString().PadRight(50));
            Console.WriteLine();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}