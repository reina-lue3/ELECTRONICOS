using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class ProductoController : Controller
    {
        // Carga la página inicial
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Recibe los datos del formulario directamente como strings
        [HttpPost]
        public IActionResult Index(string marca, string modelo, string descripcion)
        {
            // Validación rápida
            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
            {
                ViewBag.Error = "La marca y el modelo son campos requeridos.";
                return View();
            }

            // Aquí puedes procesar los datos (guardarlos en una lista o base de datos)
            // Por ahora, simulamos éxito enviando un mensaje a la vista
            ViewBag.Success = $"Producto {marca} {modelo} registrado correctamente.";

            return View();
        }
    }
}