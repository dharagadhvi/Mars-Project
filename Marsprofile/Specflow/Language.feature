Feature: Language
As a seller
I want a feature to add my known languages 
So that
People seeking for some skill can look into my detail

@Language
Scenario: Add language detail description with valid details
	Given I lodged into Mars Logo portal successfully
	When I add language details
	Then Language details should be able to see on profile page


	
