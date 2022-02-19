Feature: Language add
As a seller
I want a feature to add my known languages 
So that
People seeking for some skill can look into my detail

@Languageadd
Scenario Outline: Add language description with valid details
    Given I click on Language tab
   	When I add '<Language>' and '<Level>' details
	Then '<Language>' and '<Level>' should be able to see on Language profile  page

    Examples: 
	| Language |   Level          |
	| Hindi    |   Conversational |

	#@Language
#Scenario: Add detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#   	When I add language and Leveldetails
#	Then Language details should be able to see on profile page

#Examples: 
#	| Language |   Level          |
#	| Hindi    |   Conversational |
#	| English  |   Fluent         |
##
#@Language	
#Scenario: Add duplicate detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#    And I navigate to profile page
#	When I add duplicate <language> details
#	Then Language details should  not be able to see on profile page and <error message> should be seen
#	#Examples: 
#	#| Language  | error message                                        |
#	#| Hindi     | This Language is alreday exist in your language List |
#	
#@Language	
#Scenario: Edit  detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#    And I navigate to profile page
#	When I edit language and level details
#	Then Language edited details should be able to see on profile page
#
#	#Examples: 
#	#| Language |   Level          |
#	#| Hindi    |   Fluent         |
#	#| English  |   Conversational |
#
#
#@Language	
#Scenario: Delete  detail description with valid details
#Given I lodged into Mars Logo portal successfully
#    And I navigate to profile page
#	When I delete language details
#	Then Language details should  not be  able to see on profile page
#
#
#
	