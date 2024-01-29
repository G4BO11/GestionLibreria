namespace GestionLibreriaPrueba.DTO;

public class LibroDto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int AutorId { get; set; }
    public string AutorNombre { get; set; }
}