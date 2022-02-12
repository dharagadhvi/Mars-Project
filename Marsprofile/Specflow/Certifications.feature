Feature: Certifications

As a seller
I want a feature to add my certificate
So that
People seeking for some skill can look into my detail

@Certifications
Scenario: Add certificate detail 
    Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I add <Certificate>,<From>,<Year> details
	Then Profile details should be able to see on profile page
	#Examples: 
	#| Certificate |  | From |  | Year |
	#| ITIL        |  | DEF  |  | 2021 |

	@Certifications
Scenario: Add duplicate certificate detail description with valid details
    Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I add <Certificate>,<From>,<Year> details
	Then Profile details should be able to see on profile page
	#Examples: 
	#| Certificate |  | From |  | Year |  | error message                                              |
	#| ITIL        |  | DEF  |  | 2021 |  | This certificate is alreday exist in your certificate List |

	@Certifications
Scenario: edit certificate detail description with valid details
    Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I edit <Certificate>,<From>,<Year> details
	Then Profile details should be able to see on profile page
	#Examples: 
	#| Certificate |  | From |  | Year |  
	#| ITIL        |  | DEF  |  | 2022 | 

	@Certifications
Scenario: delete certificate detail description 
    Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I delete Certificate details
	Then Profile details should not be able to see on profile page 
	