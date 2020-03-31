using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey); //GetArticles is a static method so that's why it is called on Article class itself.
			return View(allArticles);
		}
	}
}