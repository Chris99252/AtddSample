using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;

namespace MyWeb.Tests.PageObjects
{
	public class WelcomePage : PageObject<WelcomePage>
	{
		public WelcomePage(FluentTest test)
			: base(test)
		{

		}

		internal void CheckAt()
		{
			throw new NotImplementedException();
		}

		internal void WelcomeMessage(string welcomeMessage)
		{
			throw new NotImplementedException();
		}
	}
}
