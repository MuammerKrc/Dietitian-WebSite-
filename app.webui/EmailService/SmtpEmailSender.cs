using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace app.webui.EmailService
{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSl;
        private string _username;
        private string _password;

        public SmtpEmailSender(string host, int port, bool enableSSl, string username, string password)
        {
            this._host = host;
            this._port = port;
            this._enableSSl = enableSSl;
            this._username = username;
            this._password = password;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = this._enableSSl,
                Timeout = int.MaxValue

            };

            return client.SendMailAsync(
                new MailMessage(this._username, email, subject, htmlMessage)
                {
                    IsBodyHtml = true,

                }
            );
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage, Attachment _attachment)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = this._enableSSl,
                Timeout = int.MaxValue

            };
            
            var mail = new MailMessage(this._username,email,subject,htmlMessage);
            mail.Attachments.Add(_attachment);
           
            return client.SendMailAsync(mail);
        }


    }
}