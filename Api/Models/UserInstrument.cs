namespace Instrumental.Models;
public class UserInstrument : BaseEntity
{
    public int UserId { get; set; }
    public User? User { get; set; }

    public int InstrumentId { get; set; }
    public Instrument? Instrument { get; set; }
}
