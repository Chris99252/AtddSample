using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;

namespace MyWeb.Tests.PageObjects
{
	public class LoginPage : PageObject<LoginPage>
	{
		private Steps.LoginSteps loginSteps;

		public LoginPage(FluentTest test)
			: base(test)
		{

		}

		internal void Account(string account)
		{
			throw new NotImplementedException();
		}

		internal void Password(string password)
		{
			throw new NotImplementedException();
		}

		internal void Login()
		{
			throw new NotImplementedException();
		}
	}
}
