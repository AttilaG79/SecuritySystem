using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurityDataModel;
using SecuritySystem.Models;

namespace SecuritySystem.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StoreController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<StoresData> ObjStores = _context.StoresDatas.OrderBy(x=>x.StoreName).ToList();
            return View(ObjStores);           
        }
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StoresData data)
        {
           
            
            if (ModelState.IsValid)
            {
                _context.StoresDatas.Add(data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");   
            }
            return View(data);
        }

        public IActionResult Edit(int Id)
        {   
            if(Id == 0 )
            {
                return NotFound();
            }
            var data = _context.StoresDatas.Find(Id);  
            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StoresData data)
        {
            if (ModelState.IsValid)
            {
                _context.StoresDatas.Update(data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }
       
        public async Task<IActionResult> Delete(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }
            var del = await _context.StoresDatas.FirstOrDefaultAsync(m => m.StoreId == Id);          
            if(del == null)
            {
                return NotFound();
            }
            return View(del);
        }
        [HttpPost, ActionName("Delete")]  
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var delete = _context.StoresDatas.Find(Id);
            if(delete == null)
            {
                return NotFound();
            }
            _context.StoresDatas.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int Id)
        {
            var details = _context.StoresDatas.FirstOrDefault(x => x.StoreId == Id);
            return View(details);   
        }
    }
}
