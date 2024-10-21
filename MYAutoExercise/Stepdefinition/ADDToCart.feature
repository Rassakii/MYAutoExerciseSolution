Feature: ADDToCart

A short summary of the feature

@tag1
Scenario: Add to cart
	Given Test automation page is loaded succesfully
	When user clicks on product page
	And All products are displayed successfully
	And user clicks on   add to cart for blue Top
	And user clicks on continue shopping
	And user clicks on add to cart for men Tshirt
	And user clicks on continue shopping
	And user clicks on add to cart for sleeveless dress
	And user clicks on view cart
	And user clicks on Proceed to check out
	Then Product are shown in checkoutPage