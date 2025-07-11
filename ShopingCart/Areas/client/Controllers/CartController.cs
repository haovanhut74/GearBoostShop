using Microsoft.AspNetCore.Mvc;

namespace ShopingCart.Areas.client.Controllers;

[Area("client")]
public class CartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}