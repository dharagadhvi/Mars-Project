Feature: Language
As a seller
I want a feature to add my known languages 
So that
People seeking for some skill can look into my detail

@Language
Scenario: Add language detail description with valid details
	When I add <language> and <Level>details
	Then Language details should be able to see on profile page

	Examples: 
	| Language |  | Level          |
	| Hindi    |  | Conversational |
	| English  |  | Fluent         |

@Language	
Scenario: Add duplicate language detail description with valid details
	When I add duplicate <language> details
	Then Language details should  not be able to see on profile page and <error message> should be seen
	Examples: 
	| Language |  | error message                                        |
	| Hindi    |  | This Language is alreday exist in your language List |
	
@Language	
Scenario: Edit language detail description with valid details
	When I edit language details
	Then Language edited details should be able to see on profile page

	Examples: 
	| Language |  | Level          |
	| Hindi    |  | Fluent         |
	| English  |  | Conversational |


@Language	
Scenario: Delete language detail description with valid details
	When I delete language details
	Then Language details should  not be  able to see on profile page



