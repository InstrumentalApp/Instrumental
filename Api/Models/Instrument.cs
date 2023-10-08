#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TeamFive.Models;
public class Instrument : BaseEntity
{
    // Specific Name of the instrument
    [Required]
    public string InstrumentName { get; set; }

    // Category for instruments to be searched under.
    // String, Brass, Woodwind, Percussion, Keyboard, Vocal
    [Required]
    public string Category { get; set; }

}
