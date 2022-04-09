using Microsoft.AspNetCore.Mvc;
using SecurityDataModel;
using SecuritySystem.Models;
using System.Collections.Generic;

namespace SecuritySystem.Controllers
{
    public class OfficerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfficerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<OfficerData> GetOfficerData = _context.OfficerDatas.OrderByDescending(x=>x.OfficerRegistrationTime).ToList();
            return View(GetOfficerData);
        }
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OfficerData data)
        {
            if (ModelState.IsValid)
            {
                _context.OfficerDatas.Add(data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult Edit(int Id)
        {
           if(Id == 0)
            {
                return NotFound();
            }
           var data = _context.OfficerDatas.Find(Id);
            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(OfficerData data)
        {
            if (ModelState.IsValid)
            {
                _context.OfficerDatas.Update(data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult Details(int Id)
        {
            var data = _context.OfficerDatas.FirstOrDefault(x=>x.OfficerId == Id);
            return View(data);
        }
        public IActionResult Delete(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }
            var data = _context.OfficerDatas.Find(Id);
            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }
    
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeletePost(int? Id)
            {
                var delete = _context.OfficerDatas.Find(Id);
                if (delete == null)
                {
                    return NotFound();
                }
                _context.OfficerDatas.Remove(delete);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }

