Feature: DoveWebFeatures
	To Automate the Dove web application features using specflow


Scenario: Searching and Veryfing the text shampoo
	Given I opened the dove home url
	When I Click on search
	And I entered search text shampoo ans searched
	Then I verify the text Shampoo text in the page

Scenario: Discover more 
	Given I opened the dove home url of dove
	When I click on discover more
	Then I verify the text “The Real Women behind #StopTheBeautyTest in page

Scenario: Terms of use
	Given I opened the dove home url of dove Web application
	When I Clicked on terms of use
	Then I Verify the section Prohibited uses