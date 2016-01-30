Feature: Addition
  As a mathematician
  I want my calculator to add numbers
  So I can know their sum

  Scenario: Adding numbers to get a sum
    When I add two numbers
    Then I get the sum

  Scenario: Adding zero
    When I add zero to a number
    Then the sum is that number

  Scenario: Adding numbers in different orders
    When I add the same numbers in different orders
    Then the sums are the same

  Scenario: Adding more than two numbers
    When I add more than two numbers
    Then I get the sum
