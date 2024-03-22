using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class ScheduleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
