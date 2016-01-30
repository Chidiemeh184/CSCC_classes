require 'calculator'

When /^I subtract two numbers$/ do
  @difference = Calculator.new.subtract 10, 5
end

Then /^I get the difference$/ do
  expect(@difference).to eq 5
end

When /^I subtract zero from a number$/ do
  @difference = Calculator.new.subtract 6, 0
end

Then /^the difference is that number$/ do
  expect(@difference).to eq 6
end

When /^I subtract the same numbers in different orders$/ do
  calc = Calculator.new
  @difference1 = calc.subtract 10, 5
  @difference2 = calc.subtract 5, 10
end

Then /^the difference is not the same$/ do
  expect(@difference1).not_to eq @difference2
end

When /^I subtract many numbers$/ do
  @difference4 = Calculator.new.subtract 15, 6, 3
end

Then /^I get the difference of many numbers$/ do
  expect(@difference4).to eq 6
end

