namespace GestionLibreriaPrueba.DTO;

public class LibroDto
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string LibTitulo { get; set; }
        public string LibGenero { get; set; }
        public int AutorID { get; set; }
    }
}