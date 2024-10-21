Feature: VerifyProductPage

A short summary of the feature

@tag1
Scenario: verify product page
	Given Test automation page  has been opened successfully
	When A user clicks on product page
	And All product is displayed successfully
	And user clicks on view product 
	Then Productname,category, price, availability, condition, brand is displayed successfully