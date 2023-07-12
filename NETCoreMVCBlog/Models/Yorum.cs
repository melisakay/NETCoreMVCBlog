namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        public int ID { get; set; }
        public int Yorumİcerik { get; set; }
        public DateTime Tarih = DateTime.Now;
    }
}
