Feature: AuthService
	
Scenario Outline:  Validate
	Given id is <id>
	And password is <password>
	And ProfileDao is stub
	And ProfileDao's GetPassword will return <passwordFromDao>
	And Hash is stub
	And Hash's GetHash will return <hashResult>
	When I invoke Validate
	Then the result should be <result>

	Examples: 
	| scenario | id       | password | result | passwordFromDao | hashResult |
	| valid    | joeychen | 1234     | true   | ooxx            | ooxx       |
	| invalid  | joeychen | abc      | false  | ooxx            | xxxx       |
