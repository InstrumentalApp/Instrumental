#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

namespace TeamFive.Models;
public class InstrumentDto
{
    public int InstrumentId { get; set; }
    public string Name { get; set; }

    public string Family { get; set; }

    public InstrumentDto(Instrument instrument)
    {
        InstrumentId = instrument.InstrumentId;
        Name = instrument.Name;
        Family = instrument.Family;
    }
}
