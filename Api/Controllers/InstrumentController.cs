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
    private readonly IInstrumentService _instrumentService;
    private readonly ILogger<InstrumentController> _logger;
    public InstrumentController(IInstrumentService InstService, ILogger<InstrumentController> logger)
    {
        _instrumentService = InstService;
        _logger = logger;
    }

    [HttpGet("all")]
    public async Task<ActionResult<List<Instrument>>> AllInstruments()
    {
        List<Instrument> instrumentList = await _instrumentService.AllInstruments();

        return instrumentList;
    }

    [HttpGet("one")]
    public async Task<ActionResult<Instrument>> OneInstrument()
    {
        Instrument? oneInstrument = await _instrumentService.OneInstrument();
        if (oneInstrument == null)
        {
            return BadRequest("Resource not found");
        }
        return oneInstrument;
    }


}
