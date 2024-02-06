using GestionLibreriaPrueba.Models;

public class DetalleLibroViewModel
{
    public Libro? Libro { get; set; }
    public IEnumerable<Comentario> Comentarios { get; set; }

}