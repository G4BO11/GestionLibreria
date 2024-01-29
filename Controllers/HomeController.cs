using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.DTO;
using Microsoft.EntityFrameworkCore;

namespace GestionLibreriaPrueba.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private GestionLibreriaContext _context;

    public HomeController(ILogger<HomeController> logger, GestionLibreriaContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var libros = await _context.Libros
            .Include(l => l.Autor)
            .Select(l => new LibroDto
            {
                Id = l.LibroID,
                Titulo = l.LibTitulo,
                Genero = l.LibGenero,
                AutorId = l.AutorID,
                AutorNombre = l.Autor.Nombre
            })
            .ToListAsync();
        return View(libros);
    }
    public async Task<IActionResult> NuevoLibro()
    {
        var autores = await _context.Autores.Select(a => new AutorDto
        {
            Id = a.AutorId,
            Nombre = a.Nombre
        }).ToListAsync();

        return View(autores);
    }
    [HttpPost]
    public async Task<IActionResult> NuevoLibro(LibroInsertDto libroInsertDto)
    {
        Libro libro = new()
        {
            LibTitulo = libroInsertDto.Titulo,
            LibGenero = libroInsertDto.Genero,
            AutorID = libroInsertDto.AutorId
        };

        await _context.Libros.AddAsync(libro);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
    public IActionResult NuevoAutor()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> NuevoAutor(AutorInsertDto autorInsertDto)
    {
        Autor autor = new()
        {
            Nombre = autorInsertDto.Nombre
        };

        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}
