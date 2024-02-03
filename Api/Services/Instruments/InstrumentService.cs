using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Instrumental.DataStorage;
using Instrumental.DataTransfer.Users;
using Instrumental.Models;
using Instrumental.Services;
using Instrumental.Services.Users;

namespace Instrumental.Services.Instruments;
public class InstrumentService : IInstrumentService
{
  private readonly DBContext _context;

  public InstrumentService(DBContext context)
  {
    _context = context;
  }

  public async Task<List<Instrument>> AllInstruments()
  {
    List<Instrument> instrumentList = await _context.Instruments.ToListAsync();
    return instrumentList;
  }

  public async Task<Instrument?> OneInstrument()
  {
    Instrument? oneInstrument = await _context.Instruments.FirstOrDefaultAsync();
    return oneInstrument;
  }

}
