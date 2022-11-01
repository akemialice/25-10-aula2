using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    private readonly LabManagerContext _context;

    public ComputerController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index() =>  View(_context.Computers);

    public IActionResult Show(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return RedirectToAction("Index");
        }

        return View(computer);


    }

    //UPDATE
        public IActionResult Uptade(int id)
    {

    }

    //READ
        public IActionResult Read(int id)
    {

    }

    //CRIAR
     public IActionResult Criar(int id)
    {
    }

    //DELETAR
    public IActionResult Deletar(int id)
    {
        _context.Computers.Remove(_context.Computers.Find(id));
        return View();
    }

    
 
}
