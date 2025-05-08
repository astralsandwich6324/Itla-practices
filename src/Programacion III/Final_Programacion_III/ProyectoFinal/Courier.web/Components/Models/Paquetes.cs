using System.ComponentModel.DataAnnotations;

namespace Courier.web.Components.Models
{
    public class Paquetes
    {
        [Key]
        public int Id { get; set; }

        public int HistoryId { get; set; }
        public enum Estatus
        {
            Transito,
            Entregado,
            EnAlmacen,
            EnEspera,
            Perdido,
            EnCamino,
            Cancelado

        }

        public Estatus Estado { get; set; }

        public bool Retenido { get; set; }

        public int Numero { get; set; } 

        public DateTime Fecha {get; set;} 

        public string Destino { get; set; }

        public string Proveedor { get; set; }

        public string Contenido { get; set; }

        public double Peso { get; set; }

        public double Volumen { get; set; }

        
    }

}
