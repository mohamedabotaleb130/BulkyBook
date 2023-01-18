
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System.Threading.Tasks;
namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        public  Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("mohamedabotaleb2019@outlook.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

            //send email
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
                //emailClient.Authenticate("momoabo80@gmail.com", "btsdtqrdlhccfima");
                //emailClient.Authenticate("momoabo80@gmail.com", "ywlcbthcsqreqsrk");
                emailClient.Authenticate("conrad28@ethereal.email'", "XsFrCw3FHpkKp9FvAx");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }

            return Task.CompletedTask;





            //var fromMail = "mohamedabotaleb2019@outlook.com";
            //var fromPassword = "01028437278abotaleb";

            //var message = new MailMessage();
            //message.From = new MailAddress(fromMail);
            //message.Subject = subject;
            //message.To.Add(email);
            //message.Body = $"<html><body>{htmlMessage}</body></html>";
            //message.IsBodyHtml = true;

            //var smtpClient = new SmtpClient("smtp-mail.outlook.com")
            //{
            //    Port = 587,
            //    Credentials = new NetworkCredential(fromMail, fromPassword),
            //    EnableSsl = true
            //};

            //smtpClient.Send(message);











        }
    }
}