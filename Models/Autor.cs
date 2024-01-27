using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLibreriaPrueba.Models;
public class Autor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AutorId { get; set; }
    public string Nombre { get; set; }
    public virtual ICollection<Libro> Libros { get; set; }
}