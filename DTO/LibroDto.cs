using GestionLibreriaPrueba.Models;

namespace GestionLibreriaPrueba.DTO;

public class LibroDto
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public string? Descripcion { get; set; }
    public int Anno { get; set; }
    public string? Editorial { get; set; }
    public int AutorId { get; set; }
    public string? AutorNombre { get; set; }
    public ICollection<Comentario>? ListComentarios { get; set; }
}