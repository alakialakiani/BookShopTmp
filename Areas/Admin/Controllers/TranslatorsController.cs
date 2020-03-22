using BookShopTmp.Models;
using BookShopTmp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookShopTmp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TranslatorsController : Controller
    {
        private readonly BookShopContext _context;
        public TranslatorsController(BookShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Translator.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TranslatorsCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Translator translator = new Translator()
                {
                    Name = viewModel.Name,
                    Family = viewModel.Family
                };
                _context.Add(translator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return NotFound();
            else
            {
                var translator = await _context.Translator.FirstOrDefaultAsync(t => t.TranslatorId == id);
                if (translator == null)
                    return NotFound();
                else
                    return View(translator);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Translator translator)
        {
            if (translator is null)
                return NotFound();
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Translator.Update(translator);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return View(translator);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var translator = await _context.Translator.FirstOrDefaultAsync(t => t.TranslatorId == id);
                if (translator is null)
                    return NotFound();
                else
                    return View(translator);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DoDelete(int? id)
        {
            var translator = await _context.Translator.FindAsync(id);
            _context.Translator.Remove(translator);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}