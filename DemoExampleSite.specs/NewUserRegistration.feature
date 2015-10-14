@authenticationSuperset
Feature: New User Registration
	In order to get access to the member-only features
	As a potential new user
	I want to create an account


Background: 
	Given I'm on the registration page


Scenario Outline: Password Strength Indicator	
	When I enter a password of <password>
	Then the password strength indicator should read <strength>

	Examples:
	| password		 | strength		|
	| pass			 | Poor			|
	| password		 | Average		|
	| long password  | Awesome		|


Scenario: User Name Already in Use
	When I enter valid new user details
		But the user name MrAwesome is already taken
	When I try to proceed with registration
	Then I should see an error Sorry, that username is already in use

Scenario: Email address not provided
When I have not enter email address
	And I try to proceed with registration
Then I should see an invalid email error, Invalid email address