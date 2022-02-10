using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab.Models;
using lab.Data;
using System.Text.Json;
using Google.DataTable.Net.Wrapper;

namespace lab.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;
  private readonly ApplicationDbContext _context;
  public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
  {
    _logger = logger;
    _context = context;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  public IActionResult Chart()
  {
    var students = _context.Students.ToList();
    ViewBag.Students = students;
    ViewBag.ChartJson = GenerateChartJson();
    return View();
  }

  private string GenerateChartJson()
  {
    var students = _context.Students.ToList();

    var data = students
      .GroupBy(_ => _.Department)
      .Select(g => new
      {
        Name = g.Key,
        Count = g.Count()
      })
      .OrderByDescending(cp => cp.Count)
      .ToList();

    //let's instantiate the DataTable.
    var dt = new Google.DataTable.Net.Wrapper.DataTable();
    dt.AddColumn(new Column(ColumnType.String, "Department", "Department"));
    dt.AddColumn(new Column(ColumnType.Number, "Count", "Count"));

    foreach (var item in data)
    {
      Row r = dt.NewRow();
      r.AddCellRange(new Cell[] {
             new Cell(item.Name),
             new Cell(item.Count)
         });
      dt.AddRow(r);
    }

    //Let's create a Json string as expected by the Google Charts API.
    return dt.GetJson();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
