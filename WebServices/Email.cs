using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace WebServices.Controllers
{
    public class Email
    {
        public Email()
        {
            SmtpClient client = new SmtpClient("localhost");
            client.UseDefaultCredentials = false;
      
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("postmaster@localhost.com");
            mailMessage.To.Add("postmaster@localhost.com");
            mailMessage.Body = "body";
            mailMessage.Subject = "subject";
            client.Send(mailMessage);
        }
    }
}
