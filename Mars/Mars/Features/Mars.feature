Feature: This test suite contains test sceanrio for Mars project.



Scenario: Check that New User can able to click on Join button.
	Given Log into Mars portal
	When New User can navigate and click on the Join button
	Then The registration window should open

Scenario: Check that New User can able to enter the required details in registration page.
	Given Navigate to into Mars portal
	When Click on the Join button
	And Enter the registration details 'first' 'last' 'kartavyap90@gmail.com' 'abc12345' 'abc12345'
	And Chcked the checkbox of terms and conditions
	Then User details should registered