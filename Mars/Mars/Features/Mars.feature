Feature: This test suite contains test sceanrio for Mars project.



Scenario: Check that New User can able to click on Join button.
	Given Log into Mars portal
	When New User can navigate and click on the Join button
	Then The registration window should open



#Scenario: Check that New User can able to enter the required details in registration page.
#	Given Navigate to into Mars portal
#	When Click on the Join button
#	And Enter the registration details 'first' 'last' 'aaaa1234567890000000@gmail.com' 'abc12345' 'abc12345'
#	And Chcked the checkbox and click submit button
#	Then User details should registered

Scenario: Check that Existing User can able to click on Sign In button.
	Given Open mars portal
	When User can navigate and click on the Sign button
	Then Login window should open

Scenario: Check that Existing User can able to click on Sign In button and login into portal.
	Given Navigate to Mars portal
	When Click on Sign In button
	And Enter Email address and Password 'kartavyap90@gmail.com' 'abc123'
	Then User should navigate to dashboard


