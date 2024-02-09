using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Services;
using Microsoft.AspNetCore.Mvc;

public class LibroController : Controller
{
    private ICommonService<LibroDto, LibroInsertDto> _libroService;
    private ICommonService<ComentarioDto, ComentarioInsertDto> _comentarioService;
    public LibroController(ICommonService<LibroDto, LibroInsertDto> libroService, ICommonService<ComentarioDto, ComentarioInsertDto> comentarioService)
    {
        _libroService = libroService;
        _comentarioService = comentarioService;
    }

    public async Task<ActionResult> DetalleLibro(int id)
    {
        var dto = await _libroService.GetById(id);
        return View(dto);
    }

    [HttpPost]
    public async Task<IActionResult> NuevoComentario(ComentarioInsertDto comentarioInsertDto)
    {
        await _comentarioService.Create(comentarioInsertDto);
        return RedirectToAction("DetalleLibro", new { id = comentarioInsertDto.LibroID });
    }
}