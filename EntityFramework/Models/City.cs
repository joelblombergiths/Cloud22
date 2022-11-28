using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace EntityFramework.Models;

[DebuggerDisplay("{Name} ({Id})")]
[Table("Städer")]
public class City
{
    public int Id { get; set; }

    [Column("Namn")]
    public string Name { get; set; }

    [Column("LandId")]
    public int CountryId { get; set; }

    public Country Country { get; set; }
}