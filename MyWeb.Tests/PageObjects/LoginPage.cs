using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;
using MyWeb.Tests.Util;

namespace MyWeb.Tests.PageObjects
{
	public class LoginPage : PageObject<LoginPage>
	{
		private const string AccountContainer = "#account";
		private const string PasswordContainer = "#password";
		private const string ErrorMessageContainer = "#errorMessage";

		public LoginPage(FluentTest test)
			: base(test)
		{
			Url = string.Format("{0}/{1}", MyTestContext.Domain, "Login");
		}

		internal void Account(string account)
		{
			I.Enter(account).In(AccountContainer);
		}

		internal void Password(string password)
		{
			I.Enter(password).In(PasswordContainer);
		}

		internal void Login()
		{
			I.Press("{ENTER}");
			//.Append(OpenQA.Selenium.Keys.Enter).To(keywordContainer); //for multi-browser
		}

		internal void ShowMessage(string errorMessage)
		{
			I.Assert.Text(errorMessage).In(ErrorMessageContainer);
		}
	}
}
