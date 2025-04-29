using System.ComponentModel.DataAnnotations;

namespace HotelHerrera.Models
{
    public class Reserva
    {
         [Key]
            public int Id { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaEntrada { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaSalida { get; set; }

            [Required]
            [Range(1, double.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
            public decimal ValorAPagar { get; set; }

            [Required]
            public Clientes InformacionCliente { get; set; }
      
    }
}
