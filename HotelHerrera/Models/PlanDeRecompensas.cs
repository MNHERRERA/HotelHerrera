using System.ComponentModel.DataAnnotations;

namespace HotelHerrera.Models
{
    public class PlanDeRecompensas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        [Required]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }
    }

}
