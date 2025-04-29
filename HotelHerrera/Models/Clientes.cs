using System.ComponentModel.DataAnnotations;

namespace HotelHerrera.Models
{
    public class Clientes
    {
         [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre es obligatorio")]
            [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
            public string Nombre { get; set; }

            [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100 años")]
            public int Edad { get; set; }

            [Required(ErrorMessage = "El correo es obligatorio")]
            [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
            public string Correo { get; set; }

            [Required]
            public bool EstadoActivo { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaRegistro { get; set; }
        
    }
}
