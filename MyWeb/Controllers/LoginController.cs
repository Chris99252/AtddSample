using System.Web.Mvc;
using MyWeb.Models;

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
			var isValid = this.AuthService.Validate(account, password);
			if (isValid)
			{
				return RedirectToAction("Index", "Welcome");
			}
			else
			{
				ViewBag.Message = "wrong account or password";
				return View();
			}
		}

		private Models.IAuth _auth;

		public Models.IAuth AuthService
		{
			get
			{
				if (this._auth == null)
				{
					//this._auth = new AuthService();
					this._auth = new AuthService { Hash = new MyHash(), ProfileDao = new ProfileDao() };
				}

				return this._auth;
			}
			set
			{
				this._auth = value;
			}
		}
	}
}