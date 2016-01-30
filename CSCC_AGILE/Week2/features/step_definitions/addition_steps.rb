require 'calculator'

When /^I add two numbers$/ do
  @sum = Calculator.new.add 6, 23
end

Then /^I get the sum$/ do
  expect(@sum).to eq 29
end

When /^I add zero to a number$/ do
  @sum = Calculator.new.add 6, 0
end

Then /^the sum is that number$/ do
  expect(@sum).to eq 6
end

When /^I add the same numbers in different orders$/ do
  calc = Calculator.new
  @sum1 = calc.add 6, 23
  @sum2 = calc.add 23, 6
end

Then /^the sums are the same$/ do
  expect(@sum1).to eq @sum2
end

When /^I add more than two numbers$/ do
  @sum = Calculator.new.add 15, 6, 8, 0
end

