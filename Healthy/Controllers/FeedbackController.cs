using Healthy.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Healthy.Controllers
{
	public class FeedbackController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult UploadFiles() => View();

		[HttpPost]
		public async Task<IActionResult> UploadFiles(IEnumerable<IFormFile> files)
		{
			var newCommentator = new Commentator()
			{
				Id = 5,
				FeedbackCommentatorName = "Павел",
				UserId = "5"
			};

			foreach (var file in files.Where(f => f.Length > 0))
			{
				using (var memoryStream = new MemoryStream())
				{
					await file.CopyToAsync(memoryStream);

					if (memoryStream.Length < 2097152)
					{
						newCommentator.PictureSource = memoryStream.ToArray();
					}
					else
					{
						ModelState.AddModelError("File", "The file is too large.");
					}
				}
			}

			return Ok();
		}

        [HttpGet]
        public async Task<IActionResult> Add()
		{
			return View();
		}
	}
}
