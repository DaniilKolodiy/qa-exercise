Feature: Test Tasks
	As a user I need get list of partners and list of UK offices


Scenario Outline: I get list of partmer from valtech site
	Given I go to home page on <Browser>
	And I click on menu button
	And I close cookie banner
	And I see Our Parters
	When I click on Partners button
	Then I can get list of our partners
	Examples: 
    | Browser |
    | Chrome  |
    | Edge    |
    | Firefox |

Scenario Outline: I get list of UK offices from valtech site
	Given I go to home page on <Browser>
	And I click on menu button
	And I close cookie banner
	When I click on Ofices button
	And I click on UK section
	Then I can get list of UK offices
	Examples: 
    | Browser |
    | Chrome  |
    | Edge    |
    | Firefox |