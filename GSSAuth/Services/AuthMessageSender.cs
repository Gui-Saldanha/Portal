using BLL;
using DAL;

namespace GSSAuth.Services
{
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        private readonly ILogger<AuthMessageSender> _logger;
        private readonly DBContext _dBContext;

        public AuthMessageSender(ILogger<AuthMessageSender> logger, DBContext dBContext)
        {
            _logger = logger;
            _dBContext = dBContext;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            _logger.LogInformation("Email: {email}, Subject: {subject}, Message: {message}", email, subject, message);

            CommunicationBL communicationBL = new CommunicationBL(_dBContext, null);
            communicationBL.AdicionaEmail("core@absis.com.br", email, subject, null, message, null, null);

            return Task.FromResult(0);
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            _logger.LogInformation("SMS: {number}, Message: {message}", number, message);

            CommunicationBL communicationBL = new CommunicationBL(_dBContext, null);
            communicationBL.AdicionaSMS(number, null, message, null, null);

            return Task.FromResult(0);
        }
    }
}