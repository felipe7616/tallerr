using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using taller2.Data;
using taller2.Models;

namespace taller2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        // private readonly DataContext _context;

    
        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> RegisterTicket(int id)
           {  
             if (id < 1 ||id> 5000) { ModelState.AddModelError(string.Empty, "Ya existe un país con el mismo nombre");

                  return Index();
              }

              Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(t=>t.Id==id);
              if (ticket.WasUsed==true) {
                  ModelState.AddModelError(string.Empty, "El ticket ya esta registrado");
                  return Index();
              }
              else { 

                  return View(id); }
           }



       /* public IActionResult RegisterTicket()
        {
            Ticket ticket = new() ;
            return View(ticket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(ticket);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }

            return View(ticket);
        }*/
    }
}