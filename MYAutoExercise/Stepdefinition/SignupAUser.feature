Feature: Signup

A short summary of the feature

@tag1
Scenario: sign up a User
	Given Text automation page is opened
	When When the user click on signUp
	And the user fill in name field as "Yussuph Tomilayo"
	And the user fill in Email As "Raskeemono70@gmail.com"
	And the user clicks on Sign up button
	And the user selects Mrs radiobutton
	And the user inputs password as "Rasakii"
	And  the user selects "29" "3" "2000" as the date of birth
	And user checks the checkbox buttons
	And user fill the following information
	| Firstname | Lastname | Company | Address                            | State      | City      | Zipcode | MobileNumber |
	| Tomilayo  | Yussuph  | Broad   | 57 Tintern avenue astely tyldesley | Manchester | Tyldesley | M29 7wl | 07877951389  |
	And the user select "Canada" as country
	And th user clicks create account
	And the user clicks on continue
	Then The account is created successsfully





	