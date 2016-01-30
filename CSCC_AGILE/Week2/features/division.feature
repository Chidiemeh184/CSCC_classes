Feature: Subtraction
  As a mathematician
  I want my calculator to divide numbers
  So I can know their quotient

  Scenario: Dividing numbers to get a quotient
    When I divide two numbers
    Then I get the quotient

  Scenario: Dividing by zero
    When I divide a number by zero
    Then the result is zero

  Scenario: Dividing numbers in different orders
    When I divide the same numbers in different orders
    Then the quotient is not the same

  Scenario: Diving many numbers
    When I divide many numbers
    Then I get the quotient of many numbers