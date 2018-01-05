Feature: guru99 login
	I want to be able to enter
	username and password details,
	to then login to guru99.

@mytag
Scenario: login to Guru99 Bank as a manager
	Given I open firefox
	And I go to http://www.demo.guru99.com/V4/
	When I enter mngr111933 as a userID
	And I enter UsEzavA as a password
	Then I should be logged in and see 'Manager's' as a welcome message
	And I clean up the test environment

Scenario: login to Guru99 Bank as a customer
	Given I open firefox
	And I go to http://www.demo.guru99.com/V4/
	When I enter 68561 as a userID
	And I enter password as a password
	Then I should be logged in and see 'Customer's' as a welcome message
	And I clean up the test environment