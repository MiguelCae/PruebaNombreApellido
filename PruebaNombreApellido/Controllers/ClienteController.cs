using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNombreApellido.Models;

namespace PruebaNombreApellido.Controllers
{
    public class ClienteController : Controller
    {
        private readonly PruebaNombreApellidoContext _context;


        public ClienteController(PruebaNombreApellidoContext context)
        { 
            _context = context; 
        }   
        public  IActionResult Index()
        {
            return View();
        }
    }
}
