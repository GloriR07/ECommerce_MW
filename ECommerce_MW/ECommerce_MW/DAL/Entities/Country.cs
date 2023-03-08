using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "Pais")] // Como mostrar la informacion al usuario
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres")] //limita caracteres del campo y puedo mostrar mensajes de error
        [Required(ErrorMessage = "El campo {0} es obligatorio")] // campo requerido tambien puede mostar mensajes
        public string Name { get; set; }
    }
}
