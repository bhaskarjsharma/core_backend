using System.ComponentModel.DataAnnotations.Schema;

namespace core_backend.Models
{
    public class Application
    {
        public int ApplicationId { set; get; }
        public string User { set; get; }
        public string UserName { set; get; }
        public ICollection<ApplicationAttachment> ApplicationAttachment { set; get; }
    }
}
