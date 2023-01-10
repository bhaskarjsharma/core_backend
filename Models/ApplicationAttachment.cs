using System.ComponentModel.DataAnnotations.Schema;

namespace core_backend.Models
{
    public class ApplicationAttachment
    {
        public int ApplicationAttachmentId { set; get; }
        public string FileName { set; get; }
        public string FileType { set; get; }
        public string FilePath { set; get; }
    }
}
