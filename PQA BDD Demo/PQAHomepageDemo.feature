Feature: PQAHomepageDemo
	I would like to visit the PQA homepage to check out the
     Our Ideas page

@mytag
Scenario: Follow the Our Ideas link
	Given I am on the PQA homepage      
    When I select Our Ideas
    Then I should see the Our Ideas page
