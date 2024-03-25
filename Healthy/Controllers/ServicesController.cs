using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
