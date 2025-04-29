using System.ComponentModel.DataAnnotations;

namespace HotelHerrera.Models
{
    public class Reserva
    {
        [Key]
        [MaxLength(15)]
        public string IdHabitacion { set; get; }
        public int ValorHabitacion { set; get; }
        public DateTime Ingreso { set; get; }
        public DateTime Salida { set; get; }
        [MaxLength(25)]
        public string NombreCliente { set;get; }


    }
}
