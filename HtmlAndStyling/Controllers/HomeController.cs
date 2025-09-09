using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HtmlAndStyling.Models;

namespace HtmlAndStyling.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        _logger.LogInformation("Loaded Home/Index");
        return View();
    }

    public IActionResult Broken()
    {
        _logger.LogError("Something broke lol");
        return View("Rando");
    }

    public IActionResult Student(Student student)
    {
        return View("StudentView", student);
    }

    public IActionResult New()
    {
        return View("MakeStudent");
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