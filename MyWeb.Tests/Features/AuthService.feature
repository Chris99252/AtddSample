Feature: AuthService
	
Scenario Outline:  Validate
	Given id is <id>
	And password is <password>
	When I invoke Validate
	Then the result should be <result>

	Examples: 
	| scenario | id       | password | result |
	| valid    | joeychen | 1234     | true   |
	| invalid  | joeychen | abc      | false  |
