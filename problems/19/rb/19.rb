require 'date'

puts (Date.new(1901,1,1)..Date.new(2000,12,31)).select { |d| d.strftime("%d").to_i == 1 && d.strftime("%A") == "Sunday" }.count