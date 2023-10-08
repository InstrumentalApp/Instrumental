#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TeamFive.Models;
public class InstrumentCategory : BaseEntity
{
    // Category for instruments to be searched under
    // String, Brass, Woodwind, Percussion, Keyboard, Vocal
    // Foreign Key in Instrument
    [Required]
    public string CategoryName { get; set; }

}
