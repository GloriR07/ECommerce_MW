using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Entity
    {
        [Key] // clave primaria ** si sale rojo se debe importar la libreria
        [Required] // campo requerido-Obligartorio
        public Guid Id { get; set; } // para que se me genere como "BioId" nuemros y letras

        public DateTime? CreatedDate { get; set; } // control se crea nuevo registro
                                                   // despues del tipo de dato se coloca ? quiere decir que es nuleable , es decir no obligatorio
        public DateTime? ModifiedDate { get; set;} // necasario para el createdDate puede tambien ser llamado "UpdateDate"

    }
}
