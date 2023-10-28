#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

namespace TeamFive.Models;
public class Instrument : BaseEntity
{
    [Key]
    public int InstrumentId { get; set; }
    public string Name { get; set; }

    public string Family { get; set; }
    public string? ImageUrl { get; set; }

    // Associations
    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    public virtual ICollection<UserInstrument> UserInstruments { get; set; } = new List<UserInstrument>();
}
