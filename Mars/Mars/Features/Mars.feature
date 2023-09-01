Feature: This test suite contains test sceanrio for Mars project.



Scenario: Check that New User can able to click on Join button.
	Given Log into Mars portal
	When New User can navigate and click on the Join button
	Then The registration window should open

<<<<<<< HEAD
=======
Scenario: Check that New User can able to enter the required details in registration page.
	Given Navigate to into Mars portal
	When Click on the Join button
	And Enter the registration details 'first' 'last' 'aaaa1234@gmail.com' 'abc12345' 'abc12345'
	And Chcked the checkbox and click submit button
	Then User details should registered
>>>>>>> DevTemp
