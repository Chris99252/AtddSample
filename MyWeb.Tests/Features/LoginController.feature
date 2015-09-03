Feature: LoginController	

Scenario: Login Success
	Given login account is "joeychen"
	And user's password is "1234"	
	When I invoke Index with HttpPost
	Then result's Controller name should be "Welcome"
	And result's Action name should be "Index"