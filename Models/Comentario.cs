using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLibreriaPrueba.Models;

public class Comentario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ComentarioID { get; set; }
    [Required(ErrorMessage = "Este campo es requerido")]
    public string ComentarioContenido { get; set; } = null!;

    [Required(ErrorMessage = "Este campo es requerido")]
    public DateTime ComentarioFecha { get; set; }
    public int LibroID { get; set; }
    [ForeignKey("LibroID")]
    public Libro Libro { get; set; } = null!;
}   