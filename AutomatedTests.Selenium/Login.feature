Feature: Login
	In order acess myData
	As a user
	I want to be able to login to the system


Background: 
	Given I am using a web broweer



Scenario: Login
	Given I am on the myData login page
	When I enter the username "jazz.kang@erni.ch" and password "CloudRocks@15""
	Then I will be logged in


	Scenario: Login2
	Given I am on the myData login page
	When I enter the username "marcel.tinner@erni.ch" and password "CloudRocks@15""
	Then I will be logged in


	
	Scenario: Badlogin
	Given I am on the myData login page
	When I enter the username "marcel.tinner@erni.ch" and password "badlogin""
	Then I will be logged in