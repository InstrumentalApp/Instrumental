using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Tokens;
using TeamFive.Services.Instruments;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/instrument")]
public class InstrumentController : ControllerBase
{
  // Calls on IInstrumentService
  private readonly IInstrumentService _instrumentService;

  // Imports Context and _isntrumentService
  public InstrumentController(IInstrumentService InstService)
  {
    _instrumentService = InstService;
  }

  // First Call to Database to return full instrument list stored in DB.
  // Call could be used to populate full list of instruments to choose lesson from or offer lesson for teachers.

  [HttpGet("all")]
  public async Task<ActionResult<List<Instrument>>> AllInstruments()
  {

    // Return full list of all instruments, unsorted
    // Needs await because it is calling an API

    List<Instrument> instrumentList = await _instrumentService.AllInstruments();

    return instrumentList;
  } 


  [HttpGet("one")]
  public async Task<ActionResult<Instrument>> OneInstrument()
  {
    Instrument? oneInstrument = await _instrumentService.OneInstrument();

    return oneInstrument;
  } 


}