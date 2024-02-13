namespace GestionLibreriaPrueba.DTO;

public class LibroInsertDto
{
    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public string? Descripcion { get; set; }
    public int Anno { get; set; }
    public string? Editorial { get; set; }
    public int AutorId { get; set; }
}