using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLibreriaPrueba.Models;
public class Autor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AutorId { get; set; }
    [Required(ErrorMessage = "Campo requerido")]
    public string Nombre { get; set; } = null!;
    public virtual ICollection<Libro> Libros { get; set; } = null!;
}