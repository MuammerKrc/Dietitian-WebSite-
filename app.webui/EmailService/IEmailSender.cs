using System.Net.Mail;
using System.Threading.Tasks;

namespace app.webui.EmailService
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email,string subject,string htmlMessage);
        Task SendEmailAsync(string email,string subject,string htmlMessage,Attachment attachment);

    }
}