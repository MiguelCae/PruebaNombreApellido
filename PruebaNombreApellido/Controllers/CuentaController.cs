using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaNombreApellido.Models;
using PruebaNombreApellido.ViewModel;

namespace PruebaNombreApellido.Controllers
{
    public class CuentaController : Controller
    {
        private readonly PruebaNombreApellidoContext _context;

        public CuentaController(PruebaNombreApellidoContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cuenta.ToListAsync());
        }

        public IActionResult New()
        {
            var model = new CuentaViewModel();
            PrepareSelectList(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult New(int a)
        {
            var model = new CuentaViewModel();
            PrepareSelectList(model);
            return View();
        }


        private void PrepareSelectList(CuentaViewModel model)
        {
            var clientes = _context.Clientes.ToList();
            var clienteConcat = clientes.Select(x => new { x.Id, Nombres = string.Concat(x.Nombres, " ", x.Apellidos, x.RazonSocial, " - ", x.NumeroIdentificacion) });
            ViewData["Clientes"] = new SelectList(clienteConcat, "Id", "Nombres");
            ViewData["TipoCuenta"] = new SelectList(_context.TipoCuenta, "Id", "Nombre");

        }
    }
}
