using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class TrainingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
