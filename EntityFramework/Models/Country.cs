using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace EntityFramework.Models;

using System.ComponentModel.DataAnnotations.Schema;

[DebuggerDisplay("{Name} ({Id})")]
[Table("Länder")]
public class Country
{
    public int Id { get; set; }

    [Column("Namn")]
    public string Name { get; set; }

    public ICollection<City> Cities { get; set; }
}