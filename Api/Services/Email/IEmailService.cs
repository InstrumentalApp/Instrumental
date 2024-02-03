using Instrumental.Models;

namespace Instrumental.Services.Email;
public interface IEmailService
{
    Task<bool> SendTestEmailAsync(string emailRecipient);
}
