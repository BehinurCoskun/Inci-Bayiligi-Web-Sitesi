using System.ComponentModel.DataAnnotations;//ekledik

namespace CKModel.Models
{
    public class Siparisler
    {
        [Key]
        public int SiparisID { get; set; }


        [StringLength(60), Required]
        public string UrunAdi { get; set; }

        [StringLength(60), Required]
        public string SiparisTarihi { get; set; }


        [StringLength(60), Required]
        public string Maliyet { get; set; }
    }
}
