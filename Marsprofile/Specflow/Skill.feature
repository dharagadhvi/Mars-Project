Feature: Skill
As a seller
I want a feature to add my skill
So that
People seeking for some skill can look into my detail
	
@skill
Scenario: Add skill detail description with valid details
	And I navigate to profile page
	When I add <Skill> and <Level>details
	Then Profile details should be able to see on profile page

Examples: 
| Skill            |  | Level        |
| Customer Service |  | Intermediate |
| Administration   |  | Excellent    |

@skill
Scenario: Add duplicate skill detail description with valid details
	And I navigate to profile page
	When I add duplicate <Skill> and <Level>details
	Then Profile details should  not be able to see on profile page and <error message> should be seen

Examples: 
| Skill            |  | error message                                   |
| Customer Service |  | This skill is alreday exist in your skill List  |

@skill
Scenario: edit skill detail description with valid details
	And I navigate to profile page
	When I edit <Skill> and <Level>details
	Then Profile details should be able to see on profile page

Examples: 
| Skill            |  | Level          |
| Customer Service |  | Excellent      |
| Administration   |  | Intermediate   |

@skill
Scenario: delete skill detail description 
	And I navigate to profile page
	When I delete skilldetails
	Then Profile details should not be able to see on profile page