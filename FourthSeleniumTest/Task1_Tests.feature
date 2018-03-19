Feature: Task1_Tests
	In order to find a specific item
	As a user
	I want to get all the results related to my search keyword with all the information accurately 

@mytag
Scenario: Verify that the mail Amazone page is correct and opened
	Given I have entered the correct url
	When I press Go or Enter
	Then the Home page should be displayed properly


	Scenario: Verify the search results using keyword "A Game of Thrones"
	Given I have entered the correct url and Amazon Home page is displayed properly
	And I enter the search keyword A Game of Thrones
	When I press the Search icon
	Then Verify that the first items has the title: A Game of Thrones (A Song of Ice and Fire, Book 1)
	And It has a badge “Best Seller”
	And Selected type is Paperback
	And And the price is £4.00

	Scenario: Verify the book details are correct
	Given I have searched the book "A Game of Thrones"
	And Results are displayed correcly
	When I click on the first result item
	Then the details are diplayed
	And It has a badge “Best Seller”
	And Selected type is Paperback
	And And the price is £4.00

	Scenario: Verify the book can be added to the basket
	Given I have searched the book "A Game of Thrones"
	And Navigate to book details page
	When I click Add to basket button
	Then Verify that the notification is shown with the title Added to Basket
	And There is one item in the basket
	And Click on edit the basket
	And Verify that the book is shown on the list
	And The title, type of print is paperback, price is £4.00, quantity is 1, and 	total price is £4.00