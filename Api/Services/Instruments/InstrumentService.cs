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
    List<Instrument>? instrumentList = _context.Instruments.ToList();

    await Task.Delay(1);

    return instrumentList;
  } 


  // Get one Instrument
  public async Task<Instrument?> OneInstrument()
  {

    // Return full list of all instruments, unsorted
    Instrument? oneInstrument = _context.Instruments.FirstOrDefault();

    await Task.Delay(1);

    return oneInstrument;
  } 

}