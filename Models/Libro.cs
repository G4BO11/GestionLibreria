using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLibreriaPrueba.Models;
public class Libro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibroID { get; set; }
    [Required]
    public string? LibTitulo { get; set; }
    public string? LibGenero { get; set; }
    public int AutorID { get; set; }

    [ForeignKey("AutorID")]
    public virtual Autor? Autor { get; set; }
    public virtual ICollection<Comentario> Comentarios { get; set; }
}