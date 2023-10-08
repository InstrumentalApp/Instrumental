using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/instrument")]
public class InstrumentController : ControllerBase
{
  private readonly DBContext _context;

  public InstrumentController(DBContext context)
  {
    _context = context;
  }

  // First Call to Database to return full instrument list stored in DB.
  // Call could be used to populate full list of instruments to choose lesson from or offer lesson for teachers.

  [HttpGet("all")]
  public async Task<ActionResult<List<Instrument>>> AllInstruments()
  {

    await Task.Delay(1);

    // Return full list of all instruments, unsorted
    List<Instrument> InstrumentList = _context.Instruments.ToList();

    return (InstrumentList);
  } 


  // Get Instruments by Category
  // This was chosen as a string search since an int category was suggested against for the React app

  [HttpGet("{category}")]
  public async Task<ActionResult<List<Instrument>>> InstrumentCategory(string category)
  {

    await Task.Delay(1);

    // Returns list of instruments, where Category = category in search
    List<Instrument> InstrumentCategory = _context.Instruments.Where(i => i.Category == category).ToList();

    return (InstrumentCategory);
  }


}