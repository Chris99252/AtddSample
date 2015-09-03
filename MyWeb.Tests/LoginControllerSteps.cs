using System;
using TechTalk.SpecFlow;

namespace MyWeb.Tests.Steps
{
	[Binding]
	[Scope(Feature = "LoginController")]
	public class LoginControllerSteps
	{
		[Given(@"login account is ""(.*)""")]
		public void GivenLoginAccountIs(string account)
		{
			ScenarioContext.Current.Pending();
		}

		[Given(@"user's password is ""(.*)""")]
		public void GivenUserSPasswordIs(string password)
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I invoke Index with HttpPost")]
		public void WhenIInvokeIndexWithHttpPost()
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"result's Controller name should be ""(.*)""")]
		public void ThenResultSControllerNameShouldBe(string controllerName)
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"result's Action name should be ""(.*)""")]
		public void ThenResultSActionNameShouldBe(string actionName)
		{
			ScenarioContext.Current.Pending();
		}
	}
}