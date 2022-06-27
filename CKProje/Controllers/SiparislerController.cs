using CKDataAccess.Data;//ekledi
using CKModel.Models;//ekledik
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CKProje.Controllers
{
    public class SiparislerController : Controller
    {
        private readonly ApplicationDbContext _db;


        public SiparislerController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var objList = _db.Siparisler.ToList();
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Siparisler obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var ob = await _db.Siparisler.FindAsync(id);
            return View(ob);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(Siparisler ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(ob);
        }
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Siparisler.FindAsync(id);
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Siparisler.FindAsync(id);
            _db.Siparisler.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
