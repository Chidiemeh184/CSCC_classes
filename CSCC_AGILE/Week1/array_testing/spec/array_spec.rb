require 'rspec'

describe Array do
	
	it 'can be empty' do
		my_array = Array.new
		expect(my_array).to be_empty
	end
end