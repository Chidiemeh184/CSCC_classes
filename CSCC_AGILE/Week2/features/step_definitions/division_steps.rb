require 'calculator'

When /^I divide two numbers$/ do
  @quotient = Calculator.new.divide 10, 5
end

Then /^I get the quotient$/ do
  expect(@quotient).to eq 2
end

When /^I divide a number by zero$/ do
  @quotient = Calculator.new.divide 6, 0
end

Then /^the result is zero$/ do
  expect(@quotient).to eq 0
end

When /^I divide the same numbers in different orders$/ do
  calc = Calculator.new
  @quotient1 = calc.divide  10, 5
  @quotient2 = calc.divide 5, 10
end

Then /^the quotient is not the same$/ do
  expect(@quotient1).not_to eq @quotient2
end

When /^I divide many numbers$/ do
  @quotient = Calculator.new.divide 18, 6, 3
end

Then /^I get the quotient of many numbers$/ do
  expect(@quotient).to eq 1
end
