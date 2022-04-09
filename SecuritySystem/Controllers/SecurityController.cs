using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurityDataModel;
using SecuritySystem.Models;
using SecuritySystem.ModelsViewData;


namespace SecuritySystem.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var dataModels = _context.SecurityDatas.Include(x=>x.StoresDatas)              

            return View(dataModels);
        }
        public IActionResult Create()
        {
            var data = new SecurityDataView();
            data.SecurityData = new SecurityData();
            data.StoresDatas = _context.StoresDatas.ToList();
            data.OfficerDatas = _context.OfficerDatas.ToList();
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SecurityData securityData)
        {
            if (ModelState.IsValid)
            {                               
                _context.SecurityDatas.Add(securityData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            var dataview = new SecurityDataView();
            dataview.SecurityData = new SecurityData();
            dataview.StoresDatas = _context.StoresDatas.ToList();
            dataview.OfficerDatas = _context.OfficerDatas.ToList();

            return View(dataview);
        }
        public IActionResult Details(int id)
        {
            var details = _context.SecurityDatas.FirstOrDefault(x => x.Id == id);
            return View(details);
        }
    }
}
