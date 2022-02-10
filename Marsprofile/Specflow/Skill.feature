Feature: Skill

A short summary of the feature
	
@skill
Scenario: Add skills detail description with valid details
	Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I add profile details
	Then Profile details should be able to see on profile page
