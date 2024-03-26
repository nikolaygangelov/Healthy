using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class TeamController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
