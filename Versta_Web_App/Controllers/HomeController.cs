using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Versta_Web_App.Models;

namespace Versta_Web_App.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;

        public HomeController(ApplicationContext appContext)
        {
            db = appContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(db.Orders.OrderByDescending(x => x.Id));
        }

        public IActionResult Ordercreation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ordercreation(CargoOrder cargoOrder)
        {
            db.Orders.Add(cargoOrder);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                CargoOrder? orderToDelete = await db.Orders.FirstOrDefaultAsync(o => o.Id == id);
                if (orderToDelete != null)
                {
                    db.Orders.Remove(orderToDelete);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
