using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Services;

namespace GestionLibreriaPrueba.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ICommonService<AutorDto, AutorInsertDto> _autorService;
    private ICommonService<LibroDto, LibroInsertDto> _libroService;

    public HomeController(ILogger<HomeController> logger, ICommonService<AutorDto, AutorInsertDto> autorService, ICommonService<LibroDto, LibroInsertDto> libroService)
    {
        _logger = logger;
        _autorService = autorService;
        _libroService = libroService;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var libros = await _libroService.Get();
        return View(libros);
    }
    public async Task<IActionResult> NuevoLibro()
    {
        var autores = await _autorService.Get();
        return View(autores);
    }
    [HttpPost]
    public async Task<IActionResult> NuevoLibro(LibroInsertDto libroInsertDto)
    {
        await _libroService.Create(libroInsertDto);
        return RedirectToAction("Index");
    }
    public IActionResult NuevoAutor()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> NuevoAutor(AutorInsertDto autorInsertDto)
    {
        await _autorService.Create(autorInsertDto);
        return RedirectToAction("Index");
    }
}
