using RestauranteP.Models;

namespace RestauranteP.Servicios
{
    public interface IRepositorioReservaciones
    {
    }
    public class RepositorioReservaciones: IRepositorioReservaciones
    {
        private readonly string connectionString;
        public RepositorioReservaciones(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(Reservaciones reservaciones)
        {

        }
    }
}
