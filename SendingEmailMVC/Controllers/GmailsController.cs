using SendingEmailMVC.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace SendingEmailMVC.Controllers
{
    public class GmailsController : Controller
    {
        // GET: Gmails
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gmails
        [HttpPost]
        public ActionResult Index(Gmail aGmail)
        {
            string message = String.Empty;
            try
            {
                MailMessage aMailMessage = new MailMessage("shohagmiaiiuc@gmail.com", aGmail.To);
                aMailMessage.Subject = aGmail.Subjects;
                aMailMessage.Body = aGmail.Body;
                aMailMessage.IsBodyHtml = false;


                SmtpClient aClient = new SmtpClient();
                aClient.Host = "smtp.gmail.com";
                aClient.Port = 587;
                aClient.EnableSsl = true;

                NetworkCredential aCredential = new NetworkCredential("shohagmiaiiuc@gmail.com", "Shohag1994");
                aClient.UseDefaultCredentials = true;
                aClient.Credentials = aCredential;
                aClient.Send(aMailMessage);
                message = "Successfully sent email message to recipients...";
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            ViewBag.Message = message;
            return View();
        }
    }
}
