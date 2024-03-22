using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class FeedbackController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
