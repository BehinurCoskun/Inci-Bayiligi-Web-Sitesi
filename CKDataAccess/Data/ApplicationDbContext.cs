using CKModel.Models;//ekledik miras almıstı
using Microsoft.EntityFrameworkCore;//ekledim
namespace CKDataAccess.Data
{
    public class ApplicationDbContext : DbContext//kalıtım alcak dbcontexten ve usingini ampulle ekle
                                                 //aplicationda public yapcan
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Musteriler> Musteriler { get; set; }

        public DbSet<Siparisler> Siparisler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }



    }
}
