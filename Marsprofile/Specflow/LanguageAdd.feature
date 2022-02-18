Feature: Language add
As a seller
I want a feature to add my known languages 
So that
People seeking for some skill can look into my detail

@Languageadd
Scenario: Add language description with valid details
    Given I lodged into Mars language portal successfully
   	When I add '<Language>' and '<Level>' details
	Then '<Language>' and '<Level>' should be able to see on Language profile  page

    Examples: 
	| Language |   Level          |
	| Hindi    |   Conversational |
	