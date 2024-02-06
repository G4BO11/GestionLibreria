using GestionLibreriaPrueba.Models;

namespace GestionLibreriaPrueba.DTO;

public class LibroDto
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Genero { get; set; } = null!;
    public int AutorId { get; set; }
    public string AutorNombre { get; set; } = null!;
    public ICollection<Comentario>? ListComentarios { get; set; }
}