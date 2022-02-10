Feature: Certifications

A short summary of the feature

@Certifications
Scenario: Add certificate detail description with valid details
	Given I lodged into Mars Logo portal successfully
	And I navigate to profile page
	When I add profile details
	Then Profile details should be able to see on profile page