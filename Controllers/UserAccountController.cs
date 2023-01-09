using core_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;

namespace core_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAccountController : ControllerBase
    {
        private readonly DatabaseContext db;
        public UserAccountController(DatabaseContext context)
        {
            db = context;
        }

        [HttpPost]
        public string RegisterUser(string name, string email,string password, string contact)
        {
            User newUser = new User(); // creating object of class User with name newUser

            newUser.Email = email;  // calling setter function of parameter Email
            newUser.Password = password;
            newUser.Name = name;
            newUser.ContactNumber = contact;

            db.Add(newUser);
            db.SaveChanges();

            return "";
        }


        [HttpPost]
        public string LoginUser(string email, string password)
        {

            User user = db.User.Where(m => m.Email == email && m.Password == password).First();
            if(user != null)
            {
                user.Name = "sf";
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                // login successful
            }
            else
            {
                // login unsuccessful
            }

            return "";
        }

    }
}
