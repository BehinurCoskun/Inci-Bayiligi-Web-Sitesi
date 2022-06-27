using CKDataAccess.Data;//ekledi
using CKModel.Models;//ekledik
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
namespace CKProje.Controllers
{
    public class MusterilerController : Controller
    {
        private readonly ApplicationDbContext _db;


        public MusterilerController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var objList = _db.Musteriler.ToList();
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Musteriler obj)
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

            var ob = await _db.Musteriler.FindAsync(id);
            return View(ob);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(Musteriler ob)
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
            var obj = await _db.Musteriler.FindAsync(id);
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Musteriler.FindAsync(id);
            _db.Musteriler.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
