using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace AspnetCoreMvcFull.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
