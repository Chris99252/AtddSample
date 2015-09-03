using System.Web.Mvc;

namespace MyWeb.Controllers
{
	public class LoginController : Controller
	{
		//
		// GET: /Login/

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(string account, string password)
		{
			//if (account == "joeychen" && password == "1234")
			//{
			//	return RedirectToAction("Index", "Welcome");
			//}
			//else
			//{
			//	ViewBag.Message = "wrong account or password";
			//	return View();
			//}
			var isValid = this.AuthService.Validate(account, password);
			if (isValid)
			{
				return RedirectToAction("Index", "Welcome");
			}

			return View();
		}

		public Models.IAuth AuthService { get; set; }
	}
}