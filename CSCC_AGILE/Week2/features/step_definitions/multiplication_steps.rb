require 'calculator'

When /^I multiply two numbers$/ do
  @product = Calculator.new.multiply 10, 5
end

Then /^I get the product$/ do
  expect(@product).to eq 50
end

When /^I multiply a number by zero$/ do
  @product = Calculator.new.multiply 6, 0
end

Then /^the product is zero$/ do
  expect(@product).to eq 0
end

When /^I multiply the same numbers in different orders$/ do
  calc = Calculator.new
  @product1 = calc.multiply  10, 5
  @product2 = calc.multiply  5, 10
end

Then /^the product is the same$/ do
  expect(@product1).to eq @product2
end

When /^I multiply many numbers$/ do
  @product = Calculator.new.multiply 10, 6, 3
end

Then /^I get the product of many numbers$/ do
  expect(@product).to eq 180
end