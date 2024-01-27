namespace GestionLibreriaPrueba.DTO;

public class AutorDto
{
    public int AutorId { get; set; }
    public string Nombre { get; set; }
    public virtual ICollection<Libro> Libros { get; set; }
}