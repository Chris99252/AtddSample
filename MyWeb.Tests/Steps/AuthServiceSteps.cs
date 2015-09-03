using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWeb.Models;
using TechTalk.SpecFlow;

namespace MyWeb.Tests.Steps
{
	[Binding]
	[Scope(Feature = "AuthService")]
	public class AuthServiceSteps
	{
		private AuthService _target;

		[BeforeScenario]
		public void BeforeScenario()
		{
			this._target = new AuthService();
		}

		[Given(@"id is (.*)")]
		public void GivenIdIs(string id)
		{
			ScenarioContext.Current.Set<string>(id, "id");
		}

		[Given(@"password is (.*)")]
		public void GivenPasswordIs(string password)
		{
			ScenarioContext.Current.Set<string>(password, "password");
		}


		[When(@"I invoke Validate")]
		public void WhenIInvokeValidate()
		{
			var id = ScenarioContext.Current.Get<string>("id");
			var password = ScenarioContext.Current.Get<string>("password");

			bool actual = this._target.Validate(id, password);

			ScenarioContext.Current.Set<bool>(actual, "result");
		}

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(bool expectedResult)
		{
			var actual = ScenarioContext.Current.Get<bool>("result");
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
