sum = 0
fib_1 = 1
fib_2 = 2
while fib_2 < 4_000_000:
  # print(fib_2)
  if fib_2 % 2 == 0:
    # print(fib_2," is even")
    sum += fib_2
  temp = fib_2
  fib_2 = fib_1 + fib_2
  fib_1 = temp
print(sum)
