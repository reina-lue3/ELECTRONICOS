using Microsoft.AspNetCore.Mvc;

namespace ELECTRONICO.AppMVC.Controllers
{
    public class ReporteProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TopCategorias()
        {
            // Datos simulados: Categorías de Software y Accesorios
            var categorias = new List<object>
    {
        new { Nombre = "Licencias Windows 11", Cantidad = 150, Ingreso = 12500.50 },
        new { Nombre = "Suscripciones Office 365", Cantidad = 130, Ingreso = 9800.00 },
        new { Nombre = "Teclados Mecánicos RGB", Cantidad = 95, Ingreso = 4750.00 },
        new { Nombre = "Mouse Gamer Inalámbrico", Cantidad = 88, Ingreso = 3520.00 },
        new { Nombre = "Antivirus (1 año)", Cantidad = 75, Ingreso = 2250.00 },
        new { Nombre = "Audífonos con Micrófono", Cantidad = 60, Ingreso = 4800.00 },
        new { Nombre = "Software ERP Modular", Cantidad = 45, Ingreso = 25000.00 },
        new { Nombre = "Monitores de Oficina", Cantidad = 30, Ingreso = 12000.00 },
        new { Nombre = "Cámaras Web HD", Cantidad = 25, Ingreso = 1250.00 },
        new { Nombre = "Adaptadores y Cables", Cantidad = 20, Ingreso = 400.00 }
    };

            ViewBag.TopCategorias = categorias;

            return View();
        }
    }
}