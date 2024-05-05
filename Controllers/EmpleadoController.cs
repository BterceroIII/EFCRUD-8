using Microsoft.AspNetCore.Mvc;

using EFCRUD8.Data;
using EFCRUD8.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCRUD8.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public EmpleadoController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Empleado> lista = await _appDBContext.Empleados.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Nuevo()
        {
            
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Nuevo(Empleado empleado)
        {
            await _appDBContext.Empleados.AddAsync(empleado);
            await _appDBContext.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }
    }
}
