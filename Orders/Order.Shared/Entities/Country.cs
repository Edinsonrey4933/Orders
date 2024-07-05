using System.ComponentModel.DataAnnotations;

namespace Order.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]/*Data Notation campo {0}nombre campo {1} max caracteres */
        [Required(ErrorMessage = "El campo {0} es requerido")] /*Data Notation campo requerido */
        public string Name { get; set; } = null!;
    }
}