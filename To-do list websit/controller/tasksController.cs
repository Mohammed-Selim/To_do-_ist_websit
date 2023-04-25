using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using To_do_list_websit.models;
using To_do_list_websit.models.mytask;

namespace To_do_list_websit.controller
{
    public class tasksController : Controller
    {
        private readonly context _context;

        public tasksController(context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Filter(string? nam, int? st)
        {
            var context = _context.tasks.Where(x => x.name.ToLower().Contains(nam) || nam == null)
                .Where(x => x.states == st || st == null);
            return View("index", await context.ToListAsync());
        }


     
        public async Task<IActionResult> Index()
        {

            //// Sessions            
            //var key = "asd";
            //HttpContext.Session.SetString(key, " responseContent");

            //// Cookies
            //Response.Cookies.Append(key, "responseContent");
            var context = _context.tasks;
            return View(await context.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.tasks.Include(x => x.Category).Include(x => x.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

        
        public IActionResult Create()
        {
            ViewBag.cats = _context.categories.ToList();
            ViewBag.uses = _context.users.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(tasks tasks)
        {
            
            _context.Add(tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.tasks.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }
            ViewData["Categoryid"] = _context.categories.ToList();
            ViewData["Userid"] = _context.users.ToList();
            return View(tasks);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, tasks tasks)
        {
            _context.Update(tasks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

     
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.tasks
                .Include(t => t.Category)
                .Include(t => t.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

    
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var tasks = await _context.tasks.FindAsync(id);
            if (tasks != null)
            {
                _context.tasks.Remove(tasks);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
