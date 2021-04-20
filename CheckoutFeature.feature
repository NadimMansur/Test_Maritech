Feature: Checkout Feature
	Test order checkout 

@Smoke
Scenario: Test Order Checkout Total
	Given I Order 1 of "Starter1" from Starters menu
	And I Order 1 of "Main1"  from Mains menu
	When I Checkout
	Then Total is 11.4