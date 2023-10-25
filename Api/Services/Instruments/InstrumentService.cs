using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;

namespace TeamFive.Services.Instruments;
public class InstrumentService : IInstrumentService
{
  private readonly DBContext _context;

  public InstrumentService(DBContext context)
  {
    _context = context;
  }

  // Get all instruments
  public async Task<List<Instrument>> AllInstruments()
  {

    // Return full list of all instruments, unsorted
    List<Instrument> instrumentList = await _context.Instruments.ToListAsync();

    return instrumentList;
  }


  // Get one Instrument
  public async Task<Instrument?> OneInstrument()
  {
    Instrument? oneInstrument = await _context.Instruments.FirstOrDefaultAsync();

    return oneInstrument;
  }

}
