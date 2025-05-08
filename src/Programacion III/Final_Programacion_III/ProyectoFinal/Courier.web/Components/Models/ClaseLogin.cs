using System.ComponentModel.DataAnnotations;

namespace Courier.web.Components.Models
{
    public class ClaseLogin
    {
        [Key]
        public int Id { get; set; }
        [Required] public string? Usuario { get; set; }

        [Required] public string? Mail { get; set; }

        [Required] public string? Contrasena { get; set; }

        
    }
}
