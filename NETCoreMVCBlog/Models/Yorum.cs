using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        public int ID { get; set; }
        [Required]
        public int Yorumİcerik { get; set; }
        
        public DateTime Tarih = DateTime.Now;
    }
}
