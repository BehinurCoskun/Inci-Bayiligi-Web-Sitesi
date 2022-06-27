using System.ComponentModel.DataAnnotations;//ekledik
namespace CKModel.Models
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }

        [StringLength(60), Required]

        public string UrunAdi { get; set; }

        [StringLength(60), Required]
        public string Fiyat { get; set; }




    }
}
