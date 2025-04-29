using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace HotelHerrera.Models
{
    public class Clientes
    {
        [Key]
        [MaxLength(15)]
        public string Nombre { set; get; }
        [MaxLength(15)]
        public string Telefono { set; get; }
        public int Id { set; get; }
        public DateTime Cumpleaños {set;get;}
        
        public bool Acompanantes { set; get; } 
       

        

    }
}
