using Microsoft.AspNetCore.Mvc;

namespace core_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAccountController : ControllerBase
    {
        [HttpPost]
        public string RegisterUser(string name, string email,string password)
        {
            return "";
        }
    }
}
