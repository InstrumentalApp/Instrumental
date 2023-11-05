using TeamFive.Models;

namespace TeamFive.Services.Email;
public interface IEmailService
{
    Task<bool> SendTestEmailAsync(string emailRecipient);
}
