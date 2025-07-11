using Microsoft.AspNetCore.Mvc;

namespace ShopingCart.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Detail()
    {
        return View();
    }
}