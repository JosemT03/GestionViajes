namespace GestionViajes.API.Models
{
    public class AsignacionPedidoRequest
    {
        public int PedidoId { get; set; }
        public int ChoferId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime TiempoEstimadoEntrega { get; set; }
    }
}
