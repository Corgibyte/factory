using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewData["engineers"] = _db.Engineers.ToList();
      ViewData["machines"] = _db.Machines.ToList();
      return View();
    }
  }
}