class Calculator
  def add *numbers
    numbers.inject(:+)
  end
  
  def subtract *numbers
	numbers.inject(:-)
  end
  
  def multiply *numbers
	numbers.inject(:*)
  end
  
  def divide(*n1)
		begin
			n1.inject(:/)
		rescue ZeroDivisionError 
		0
		end
	end
	
end
