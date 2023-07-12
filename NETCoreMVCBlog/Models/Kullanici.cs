using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        public int KullaniciYas { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }

    }
}
