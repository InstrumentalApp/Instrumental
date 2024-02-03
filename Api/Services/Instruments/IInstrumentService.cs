using System.Net.Http.Headers;
using Instrumental.DataTransfer.Tokens;
using Instrumental.Models;

namespace Instrumental.Services.Instruments;
public interface IInstrumentService
{
    Task<List<Instrument>> AllInstruments();
    Task<Instrument?> OneInstrument();
}
