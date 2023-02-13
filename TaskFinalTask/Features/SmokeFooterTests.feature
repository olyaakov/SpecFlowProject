Feature: SmokeFooterTests

@smoke
Scenario: Clicking Account option from the footer menu should open Your Account page
	Given User opens Amason web site
	When User hovers 'Hello, sign in' menu item from the footer menu
	And User clicks 'Account' option from the footer menu
	Then Page with 'Your account' title should be opened

@smoke
Scenario: Clicking on a product section from the main menu and selecting a product brand on the Result page should filter the products on the Result page
	Given User opens Amason web site
	When User clicks 'Shop now' item from on the main menu
	And User clicks 'Computers' item from the navigation block menu on the 'International Best Sellers' page
	And User clicks 'HP' cell from the 'Featured Brands' item from the navigation block menu on the 'Computers, Tablets and IT Accessories' page 
	Then The page 'RESULTS' contains 'HP' product brand in the product description

@smoke
Scenario: Changing the user of the Deliver to option in the footer must change the name of the country in the Deliver to option
	Given User opens Amason web site
	When User clicks 'Deliver to' item from the footer
	And User clicks 'Ukraine' button in a pop-up 
	And User clicks 'Canada' button in drop-down list
	And User clicks 'Done' button 
	Then Page with 'Canada' country in footer should be open

@smoke
Scenario: Entering symbols in the authorization field on the Sign in page
    Given User opens Amason web site
	When User clicks 'Hello, sign in' item from the footer menu
	And User enters 'Hobgislgsdpfkgpasfgbvijo' text in the authorixation field 
	And User clicks 'Continue' button on Sign in page
	Then 'Problem' message should be displayed on the page

@smoke
Scenario: Adding one item to the cart should increase the counter in the cart by one
	Given User opens Amason web site
	When User clicks 'All' item from footer
	And User clicks 'Computers' item
	And User clicks 'Printers' menu item
 	And User clicks the 'HP' cell in the navigation menu
    Then Page with the 'HP' text in the description of the product should be displayed
