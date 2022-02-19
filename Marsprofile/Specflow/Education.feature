Feature: Education

Feature: Education
As a seller
I want a feature to add my education 
So that
People seeking for some skill can look into my detail

@education
Scenario Outline: Add education detail description with valid details
    Given I click on Education tab 
    When I add '<Country>','<University>','<Title>','<Degree>','<Graduation Year>' details
	Then added '<Country>','<University>','<Title>','<Degree>','<Graduation Year>' details should be able to see on profile page

Examples: 
| Country |   University |   Title  |  Degree |  Graduation Year |
| India   |   AD Patel   |   B.Tech |   IT     |  2009            |

#@education
#Scenario: Add duplicate education detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#	When I add duplicate Country ,University,Title,Degree,Graduation Year details
#	Then education details should  not be able to see on profile page and <error message> should be seen

#Examples: 
#| Country |   Universite   | Title    | Degree   | Gradiation Year   | error Message                                          |
#| India   |   AD Patel     | B.Tech   | IT       | 2009              | This Education is alreday exist in your Education List |
#
#@education
#Scenario: edit education detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#    And  I navigate to profile page
#	When I edit <Country>.<University>,<Title>,<Degree>,<Graduation Year> details
#	Then education details should be able to see on profile page
##	Examples: 
##| Country   |  Universite  | Title    | Degree   | Gradiation Year |
##| Australia |   XYZ        | B.Tech   | IT       | 2009            |
#
#@education
#Scenario: Delete education detail description with valid details
#    Given I lodged into Mars Logo portal successfully
#	When I delete education details
#	Then education details should  not be  able to see on profile page