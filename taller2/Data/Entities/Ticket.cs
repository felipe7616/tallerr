using System.ComponentModel.DataAnnotations;

namespace taller2.Data
{
    public class Ticket
    {
        public int Id { get; set; }

      [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

       [Display(Name = "Nombres y apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public bool WasUsed { get; set; }
        public DateTime Date { get; set; }
        public Entrance entrance { get; set; }
    }
}
