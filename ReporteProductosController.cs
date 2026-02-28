using Microsoft.AspNetCore.Mvc;

namespace ELECTRONICOS.App.MVC.Controllers
{
    public class ReporteProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}



public class ReporteProductoController : Controller
{
    public IActionResult Index()
    {
        // Usamos una lista de objetos anónimos para no depender de ninguna clase "Model"
        var datosReporte = new List<object>
        {
            // Estos son ejemplos, aquí conectarías tu lógica de datos
            new { Marca = "Toyota", Modelo = "2024", Descripcion = "Repuesto de Motor", Precio = 450.00, Stock = 10 },
            new { Marca = "Nissan", Modelo = "2023", Descripcion = "Filtro de Aire", Precio = 25.50, Stock = 150 }
        };

        ViewBag.ProductosSinVentas = datosReporte;

        return View();
    }
}