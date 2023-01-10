using System.ComponentModel.DataAnnotations;

namespace core_backend.Models
{
    public class Advertisement
    {
        public int AdvertisementId { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public ICollection<Application> Application { set; get; }
    }
}
