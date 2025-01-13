using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return Content("Welcome to FranRGIS! This is the default page.");
	}
}