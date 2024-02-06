namespace GestionLibreriaPrueba.DTO;

public class LibroInsertDto
{
    public string Titulo { get; set; } = null!;
    public string Genero { get; set; } = null!;
    public int AutorId { get; set; }
}