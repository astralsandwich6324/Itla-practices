using System.ComponentModel.DataAnnotations;


namespace Courier.web.Components.Models
{
    public class PreAlertas 
    {
        [Key]
        public int Id { get; set; }
        public int? HistoryId { get; set; }

        public string? Trasportista { get; set; }

        public string? Tracking { get; set; }

        public DateTime? EntregaEstimada { get; set; }

        public string? Proveedor { get; set; }

        public int? Valor { get; set; }

        public string? Contenido { get; set; }


        public string UsuarioId { get; set; }
    }
}
