namespace RestauranteP.Models
{
    public class Reservaciones
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }

        public int ReservacionesId { get; set; }
        
        public int MesaId { get; set; }
    }
}
