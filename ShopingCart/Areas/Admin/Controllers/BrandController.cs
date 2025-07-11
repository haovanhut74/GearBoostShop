using Microsoft.AspNetCore.Mvc;

namespace ShopingCart.Areas.Admin.Controllers;
[Area("Admin")]
public class BrandController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}