Feature: This test suite contains test sceanrio for Mars project.


# Registration and Login scenario
#Scenario: New User can able to click on Join button.
#	Given Log into Mars portal
#	When New User can navigate and click on the Join button
#	Then The registration window should open
#
#For below scenario each time change the email address
#Scenario: aNew User can able to enter the required details in registration page.
#	Given Navigate to into Mars portal
#	When Click on the Join button
#	And Enter the registration details 'first' 'last' 'abc123444444@gmail.com' 'abc12345' 'abc12345'
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
#
#For below scenario each time change the email address
#Scenario: Existing User can able to click on Join button and register details from the login box.
#	Given Open portal
#	When User click on Sign In button.
#	And User click on Join button.
#	And User enter registration details 'first name' 'last name' 'a111111111111@a.com' 'abc12345' 'abc12345'
#	Then User's deatils should registered
#
#For below scenario try to use email id as above scenario
#Scenario: Existing User can able to send out verification mail for Forget Password.
#	Given Nav. to Mars portal
#	When User click on Sign In button
#	And User click on Forget your password link text
#	And Enter registered email id 'a111111111111@a.com'
#	Then Password reset link should sent to user
#
#Scenario: Registered User can not login with wrong credentials.
#	Given Open MARS posrtal 
#	When Clcik on SIGN IN button
#	And Enter wrong credentials 'kartavyap9@gmail.com' 'abc124'
#	Then User should not login 'kartavyap9@gmail.com'


# Languages Tab scenario
#Scenario: bExisiting User can add the Languges and Level from the language section in Profile page.
#	Given Opening Mars portal
#	When User login into portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button and enter details 'language3'
#	Then User's detail should registered 'language3'
#
#Scenario: Exisiting User can not add the Languges and Level without entering each of them from the language section in Profile page.
#	Given Opening to Mars portal
#	When Login into Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button withoust entering details
#	Then User received error message
#
#Scenario: Existing User can edit the Language and Level.
#	Given open portal mars
#	When Login to Portal 'kartavyap90@gmail.com' 'abc123'
#	And Edit the language and level 'edited language'
#	Then User should successfully edited language and level 
#
#For below scenario first check that you have language added
#Scenario: Existing User can delete the Language and Level.
#	Given User open mars portal
#	When User Login to portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on delete button to delete language entry
#	Then User should successfully deleted the language


# Skills Tab scenario
#Scenario: Exisiting User can add the Skills and Level from the skills section.
#	Given User Opening Mars portal
#	When User Login to mars portal 'kartavyap90@gmail.com' 'abc123'
#	And User Click on AddNew button and enter skill 'skill 1'
#	Then User details should registered 'skill 1'
#
#Scenario: Exisiting User can not add the Skill and Level without entering each of them from the skill section.
#	Given Opening to portal Mars
#	When Login to Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on AddNew button without entering skill details
#	Then User received error message for it
#
#Scenario: Existing User can edit the Skill and Level.
#	Given open to portal mars
#	When Login to Portal Mars 'kartavyap90@gmail.com' 'abc123'
#	And Edit the skill and level 'edited skill'
#	Then User should successfully edited skill and level
#
#Scenario: Existing User can delete the Skill and Level.
#	Given User open to mars portal
#	When User Login to portal mars 'kartavyap90@gmail.com' 'abc123'
#	And User click on delete button to delete skill entry
#	Then User should successfully deleted the skill


# User Profile scenarios
#Scenario: Exisiting User can click on the dropdown button to edit the First name and last name.
#	Given Launch portal
#	When User login to portal with details 'kartavyap90@gmail.com' 'abc123'
#	And User can click on the edit dropdown
#	Then User should successfully click on edit dropdown
#
#Scenario: Check that Exisiting User can edit the First name and last name.
#	Given User can Launch portal
#	When User can login to portal with details 'kartavyap90@gmail.com' 'abc123'
#	And User can edit the First name and last name 'ABC' 'DEF'
#	Then User should successfully edit the First and last name 'ABC' 'DEF'
#
#Scenario: Existing User can receive error message while hitting the Save button without entering the first and last name.
#	Given User can Launch the Mars portal
#	When User can login into the Mars portal with details 'kartavyap90@gmail.com' 'abc123'
#	And User enter the First name and last name as blank 
#	Then User should receive error message for blank first and last name 
#
#Scenario: Existing User can enter the blank space in first and last name.
#	Given User can Launch Mars portal
#	When User can login to Mars portal with details 'kartavyap90@gmail.com' 'abc123'
#	And User can enter the First name and last name as white space ' ' ' '
#	Then User should receive error message for white space first and last name ' ' ' '
#
#Scenario:	Existing User can click on the edit icon of the availability.
#	Given User nav to mars portal
#	When User login into the portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon of the availability
#	Then User should successfully click on the edit icon
#
#Scenario:	Existing User can click on the cross icon of the availability.
#	Given User nav. to mars portal
#	When User login into the mars portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on the cross icon of the availability
#	Then User should successfully click on the cross icon
#
#Scenario: Check that Existing User can change the availability value.
#	Given User launch to mars portal
#	When The Mars Portal: User Sign-In 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon and change the value of the availability
#	Then User should successfully change the value of the availability
#
#Scenario: Check that Existing User can click on the edit icon of the hours.
#	Given User navi. to mars portal
#	When Logging into the Mars portal as a user 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon of the hours
#	Then User should successfully click on the edit icon of the hours

#Scenario:	Existing User can click on the cross icon of the hours.
#	Given User navig. to mars portal
#	When User Accessing the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on the cross icon of the hours
#	Then User should successfully click on the cross icon of hours
#
#Scenario: Check that Existing User can change the hours value.
#	Given User Launch to the mars portal
#	When Login to the Martian Portal as a User 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon and change the value of the hours
#	Then User should successfully change the value of the hours
#
#Scenario: Existing User can click on the edit icon of the earn target.
#	Given User naviga. to mars portal
#	When Logging Into Mars portal as a user 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon of the earn target
#	Then User should successfully click on the edit icon of the earn target
#
#Scenario:	Existing User can click on the cross icon of the earn target.
#	Given User launch the mars portal
#	When Mars Portal User Access 'kartavyap90@gmail.com' 'abc123'
#	And User click on the cross icon of the earn target
#	Then User should successfully click on the cross icon of earn target
#
#Scenario: Existing User can change the hours earn target value.
#	Given User to Launch the mars portal
#	When Login to Martian Portal as a User 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon and change the value of the earn target
#	Then User should successfully change the value of the earn target

#Description scenario
#Scenario: Existing User can click on the pencil icon of the description
#	Given Launch the mars portal
#	When Entering the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on the edit icon of the description
#	Then User should successfully click on the edit icon of the description
#
#Scenario: Existing User can receive error while entering description without first character of digit or letter.
#	Given Launch to the portal mars
#	When Enter to the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User can receive error while entering description without first character of digit or letter
#	Then User should receive error while entering description without first character of digit or letter
#
#Scenario: Existing User can enter the description.
#	Given Launch to the portal mars
#	When User Sign-In for the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User enter description in box
#	Then User should successfully enter description in box

# Education tab scenario
#Scenario: Existing User can click on the Education tab.
#	Given Launch the portal
#	When User SignIn for the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User can click on the Education tab
#	Then User should successfully click on the Education tab
#
#Scenario: Existing User can click on the Add New button from the Education tab.
#	Given Launch the QA Mars Portal
#	When User Sign-In the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click on the Add New button from the Education tab
#	Then User should successfully click on the Add New button from the Education tab
#
#Scenario: Existing User can not add the education and other details without entering each of them from the Education tab.
#	Given Launch QA Mars Portal
#	When User Login the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User not add the educations and other details and click Add button
#	Then User should successfully receive error
#
#Scenario: Existing User can click on the Cancel button from the Education tab.
#	Given Launch the Portal QA Mars
#	When User Login Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click Cancel button
#	Then User should successfully click Cancel button
#
#Scenario: Existing User can add the educations and other details from the Education tab.
#	Given Launch the QA Mars 
#	When User Login into Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User enter education details and click add button 'Royal College' 'CS' 
#	Then User should successfully enter education details 
#
#Scenario: Existing User can edit the educations and other details from the Education tab.
#	Given Launch QA Mars 
#	When Login into Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User edit education details and click add button 'Saint University' 'MBBS' 
#	Then User should successfully edited education details 
#
#Scenario: Existing User can delete the educations and other details from the Education tab.
#	Given Launch QA portal Mars 
#	When Login Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User delete education details by clicking on the cross icon 
#	Then User should successfully delete education details 


# Certification tab scenario
#Scenario: Existing User can click on the Certification tab.
#	Given Launch Portal qa mars 
#	When User SignIn the Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User can click on the Certification  tab
#	Then User should successfully click on the Certification  tab
#
#Scenario: Existing User can click on the Add New button from the Certification tab.
#	Given Launch the QA Mars website
#	When User Sign-In the Mars website 'kartavyap90@gmail.com' 'abc123'
#	And User click on the Add New button from the Certification tab
#	Then User should successfully click on the Add New button from the Certification tab
#
#Scenario: Existing User can not add the certification and other details without entering each of them from the Certification tab.
#	Given Launch QA Mars URL
#	When User Login into the Mars Portal website 'kartavyap90@gmail.com' 'abc123'
#	And User not add the certification and other details and click Add button
#	Then User should successfully receive error for it
#
#Scenario: Existing User can click on the Cancel button from the Certification tab.
#	Given User Launch the Portal QA Mars
#	When Registered User Login to Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User click Cancel button in Certification tab
#	Then User should successfully click Cancel button in Certification tab
#
#Scenario: Existing User can add the certification and other details from the Certification tab.
#	Given Launch Mars 
#	When Existing User Login into Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User enter certification details and click add button 'Certificate 1' 'MVP Studio' 
#	Then User should successfully enter certification details
#
#Scenario: Existing User can edit the certification and other details from the Certification tab.
#	Given Launch QA Mars website
#	When Login into Mars Portal website 'kartavyap90@gmail.com' 'abc123'
#	And User edit certification details and click add button 'Certificate 2' 'Industry Connect' 
#	Then User should successfully edited certification details 
#
#Scenario: Existing User can delete the certification and other details from the Certification tab.
#	Given Launch website Mars
#	When Login QA Mars Portal 'kartavyap90@gmail.com' 'abc123'
#	And User delete certification details by clicking on the cross icon 
#	Then User should successfully delete certification details 

