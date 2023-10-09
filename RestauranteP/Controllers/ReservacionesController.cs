using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RestauranteP.Models;

namespace RestauranteP.Controllers
{
    public class ReservacionesController : Controller
    {
       
        public IActionResult Crear(Reservaciones reservaciones)
        {
           
            return View();
        }
    }
}
