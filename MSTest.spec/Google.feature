Feature: Google
	In order to experience VS Selenium SpecFlow
	As a test automation specialist
	I want to check Google page

@mytag
Scenario: Google landing page
	Given I started web browser
	When I navigate to google.com
	Then Google landing page will be shown
