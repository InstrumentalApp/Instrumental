#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeamFive.Attributes;

namespace TeamFive.Models;
public class UserInstrument : BaseEntity
{
    public int UserId { get; set; }
    public User? User { get; set; }

    public int InstrumentId { get; set; }
    public Instrument? Instrument { get; set; }
}
