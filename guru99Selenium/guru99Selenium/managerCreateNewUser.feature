Feature: guru99ManagerNewCustomer
	As a logged in manger, i can
	create and register a new 
	customer.

Scenario: Log in as a manager, and create a new customer
	Given I open firefox as the browser
	And I visit http://www.demo.guru99.com/V4/ 
	When I enter mngr111933 as the userID
	And I enter UsEzavA as the password
	When I click the new customer tab
	And I enter joel as the customer name
	And I select male as the gender
	And I enter 08/02/1995 as the date of birth
	And I enter 123 street as the address
	And I enter new york as the city
	And I enter new york as the state
	And I enter 123456 as the pin
	And I enter 07938263849 as the mobile number
	And I enter joel@email.com as the email
	And I enter password as the password
	Then I should see 'Customer Registered Successfully!!!' as a success message
	And I clean the test environment

