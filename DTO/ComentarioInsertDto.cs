public class ComentarioInsertDto
{
    public string Contenido { get; set; } = null!;
    public DateTime Fecha { get; set; }
    public int LibroID { get; set; }
    public ComentarioInsertDto()
    {
        Fecha = DateTime.Now;
    }
}