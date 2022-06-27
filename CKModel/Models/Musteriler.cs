using System.ComponentModel.DataAnnotations;//ekledik
namespace CKModel.Models
{
    public class Musteriler
    {

        [Key]
        public int MusteriID { get; set; }
        [StringLength(60), Required]
        public string MusteriAdi { get; set; }

        [StringLength(60), Required]
        public string UrunAdi { get; set; }




    }
}
