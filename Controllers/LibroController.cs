using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Services;
using Microsoft.AspNetCore.Mvc;

public class LibroController : Controller
{
    private ICommonService<LibroDto, LibroInsertDto> _libroService;
    public LibroController(ICommonService<LibroDto, LibroInsertDto> libroService)
    {
        _libroService = libroService;
    }

    public async Task<ActionResult> DetalleLibro(int id)
    {
        var dto = await _libroService.GetById(id);
        return View(dto);
    }
}