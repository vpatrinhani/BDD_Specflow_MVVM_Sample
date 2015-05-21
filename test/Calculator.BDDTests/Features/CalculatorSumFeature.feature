Feature: CalculatorSumFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I press add
	And I have entered 70 into the calculator
	When I press equals
	Then the result should be 120 on the screen

Scenario: Add three numbers
	Given I have entered 70 into the calculator
	And I press add
	And I have entered 50 into the calculator
	And I press add
	And I have entered 80 into the calculator
	When I press equals
	Then the result should be 200 on the screen
