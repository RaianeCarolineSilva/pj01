using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pj01.Models;

namespace pj01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        try{
                
                throw new Exception("Erro especifico");
                TempData["Sucesso"] = "Cadastrado com Sucesso!";


        }catch(Exception ex){

                TempData["Erro"] = "Erro na execução do sistema";
        }
      
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
