using core_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace core_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly DatabaseContext db;
        public HomeController(DatabaseContext context)
        {
            db = context;
        }
        public List<Advertisement> CurrentOpenings()
        {
            List<Advertisement> advertisements = db.Advertisement.ToList();
            return advertisements;
        }

        public bool Apply(int advertisementID,string userName,List<IFormFile> fileUploads)
        {
            Advertisement advertisement = db.Advertisement.Find(advertisementID);

            if(advertisement != null)
            {
                Application newApp = new()
                {
                    UserName = userName,
                };

                newApp.User = "user"; // info from current logged in user

                List<ApplicationAttachment> attachments = new();
                foreach(var item in fileUploads)
                {
                    ApplicationAttachment attachment = new()
                    {
                        FileName = item.FileName,
                        FileType = item.ContentType,
                        FilePath = ""
                    };

                    attachments.Add(attachment);
                }

                newApp.ApplicationAttachment = attachments;

                if (advertisement.Application != null && advertisement.Application.Any())
                {
                    advertisement.Application.Add(newApp);
                }
                else
                {
                    List<Application> applications = new();

                    applications.Add(newApp);

                    advertisement.Application = applications;
                }

                db.Entry(advertisement).State = EntityState.Modified;
                db.SaveChanges();
            }

            return true;
        }
    }
}
