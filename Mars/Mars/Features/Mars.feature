Feature: This test suite contains test sceanrio for Mars project.



#Scenario: New User can able to click on Join button.
#	Given Log into Mars portal
#	When New User can navigate and click on the Join button
#	Then The registration window should open

#Scenario: aNew User can able to enter the required details in registration page.
#	Given Navigate to into Mars portal
#	When Click on the Join button
#	And Enter the registration details 'first' 'last' 'abc123@gmail.com' 'abc12345' 'abc12345'
#	And Chcked the checkbox and click submit button
#	Then User details should registered

#Scenario: Existing User can able to click on Sign In button.
#	Given Open mars portal
#	When User can navigate and click on the Sign button
#	Then Login window should open

#Scenario: Existing User can able to click on Sign In button and login into portal.
#	Given Navigate to Mars portal
#	When Click on Sign In button
#	And Enter Email address and Password 'kartavyap90@gmail.com' 'abc123'
#	Then User should navigate to dashboard

#Scenario: Existing User can able to click on Join button and register details from the login box.
#	Given Open portal
#	When User click on Sign In button.
#	And User click on Join button.
#	And User enter registration details 'first name' 'last name' 'a1@a.com' 'abc12345' 'abc12345'
#	Then User's deatils should registered

#Scenario: Existing User can able to send out verification mail for Forget Password.
#	Given Nav. to Mars portal
#	When User click on Sign In button
#	And User click on Forget your password link text
#	And Enter registered email id 'aaaa123456789111111@gmail.com'
#	Then Password reset link should sent to user

#Scenario: Registered User can not login with wrong credentials.
#	Given Open MARS posrtal 
#	When Clcik on SIGN IN button
#	And Enter wrong credentials 'kartavyap9@gmail.com' 'abc124'
#	Then User should not login 'kartavyap9@gmail.com'

#Scenario: bExisiting User can add the Languges and Level from the language section in Profile page.
#	Given Opening Mars portal
#	When User login into portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button and enter details 'language3'
#	Then User's detail shoul registered 'language3'

#Scenario: Exisiting User can not add the Languges and Level without entering each of them from the language section in Profile page.
#	Given Opening to Mars portal
#	When Login into Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button withoust entering details
#	Then User received error message

#Scenario: Existing User can edit the Language and Level.
#	Given open portal mars
#	When Login to Portal 'kartavyap90@gmail.com' 'abc123'
#	And Edit the language and level 'edited language'
#	Then User should successfully edited language and level

#Scenario: Existing User can delete the Language and Level.
#	Given User open mars portal
#	When User Login to portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on delete button to delete language entry
#	Then User should successfully deleted the language

#Scenario: Exisiting User can add the Skills and Level from the skills section.
#	Given User Opening Mars portal
#	When User Login to mars portal 'kartavyap90@gmail.com' 'abc123'
#	And User Click on AddNew button and enter skill 'skill 1'
#	Then User details should registered 'skill 1'

#Scenario: Exisiting User can not add the Skill and Level without entering each of them from the skill section.
#	Given Opening to portal Mars
#	When Login to Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button without entering skill details
#	Then User received error message for it

#Scenario: Existing User can edit the Skill and Level.
#	Given open to portal mars
#	When Login to Portal Mars 'kartavyap90@gmail.com' 'abc123'
#	And Edit the skill and level 'edited skill'
#	Then User should successfully edited skill and level

Scenario: Existing User can delete the Skill and Level.
	Given User open to mars portal
	When User Login to portal mars 'kartavyap90@gmail.com' 'abc123'
	And User click on delete button to delete skill entry
	Then User should successfully deleted the skill