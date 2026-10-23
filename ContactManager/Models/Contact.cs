using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        [Required] public string Nome { get; set; }
        [Required] public string Cognome { get; set; }
        [Required] public string Email { get; set; }
        public string? Telefono { get; set; }
        public string? Azienda { get; set; }
    }
}
