using System.Diagnostics;
using InternetBanking.Core.Application.Dtos.Account;
using InternetBanking.Core.Application.Interfaces.Services;
using InternetBanking.Core.Application.Services;
using InternetBanking.Core.Application.ViewModels.User;
using Microsoft.AspNetCore.Mvc;


namespace AspnetCoreMvcFull.Controllers;

public class TablesController : Controller
{
  private readonly IProductService _productService;
  private readonly IHttpContextAccessor _httpContextAccessor;

  public TablesController(IProductService productService,      IHttpContextAccessor httpContextAccessor)
  {
    _productService = productService;
  
    _httpContextAccessor = httpContextAccessor;

  }
  //public IActionResult Basic() => View();
  public async Task<IActionResult> Basic()
  {
    var labels = await _productService.GetLabelsViewModel();
    return View(labels);
  }
}
