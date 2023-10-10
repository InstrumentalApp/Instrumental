using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Instruments;
public interface IInstrumentService
{
    Task<List<Instrument>> AllInstruments();
    Task<Instrument?> OneInstrument();
    
    //TODO: Get One Instrument;
    //TODO: Get All Instruments;



}