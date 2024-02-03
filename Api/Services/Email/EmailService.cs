using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Instrumental.DataStorage;

namespace Instrumental.Services.Email;
public class EmailService : IEmailService
{
    private readonly IAmazonSimpleEmailService _sesClient;
    private readonly ILogger<EmailService> _logger;
    private readonly IConfiguration _config;

    public EmailService(DBContext context, IAmazonSimpleEmailService sesClient, ILogger<EmailService> logger, IConfiguration config)
    {
        _sesClient = sesClient;
        _logger = logger;
        _config = config;
    }

    public async Task<bool> SendTestEmailAsync(string emailRicipient)
    {
        SendEmailRequest sendRequest = new()
        {
            Source = _config["SES:From"],
            Destination = new Destination()
            {
                ToAddresses = new List<string>() { emailRicipient }
            },
            Message = new()
            {
                Subject = new Content("Test Email Subject"),
                Body = new Body
                {
                    Html = new Content
                    {
                        Charset = "UTF-8",
                        Data = "<h1>This is a message body in html format.</h1>"
                    },
                    Text = new Content
                    {
                        Charset = "UTF-8",
                        Data = "This is the message body in text format."
                    }
                }
            }
        };
        try
        {
            var response = await _sesClient.SendEmailAsync(sendRequest);
            return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
        }
        catch (Exception ex)
        {
            _logger.LogError("Message: {Message}, Source: {Source}", ex.Message, ex.Source);
            return false;
        }
    }
}
