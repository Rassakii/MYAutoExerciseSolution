Feature: verifyContact

A short summary of the feature

@tag1
Scenario: verify contact page
	Given Test automation page  has been opened
	When A user clicks on contact us page
	And Get in touch is visible
	And user fill the following informations
	| Name     | Email                  | Subject        | body             |
	| Tomilayo | raskeemono75@gmail.com | Problem| I have a problem |
	And the user clicks uploads a file
	And the user clicks submit
	And the user clicks OK button 
	Then "Success! Your details have been submitted successfully." is displayed
	And the user clicks on Home Button
	Then the user is returned to the home page

