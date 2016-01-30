Feature: Subtraction
  As a mathematician
  I want my calculator to multiply numbers
  So I can know their product

  Scenario: Multiplying numbers to get a product
    When I multiply two numbers
    Then I get the product

  Scenario: Multiplying by zero
    When I multiply a number by zero
    Then the product is zero

  Scenario: Multiplying numbers in different orders
    When I multiply the same numbers in different orders
    Then the product is the same

  Scenario: Multiply many numbers
    When I multiply many numbers
    Then I get the product of many numbers