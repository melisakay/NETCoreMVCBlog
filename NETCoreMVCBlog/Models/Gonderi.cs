using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        public string GonderiAdi { get; set; }
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
    }
}
