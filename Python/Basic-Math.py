# Exercise 1: Check if the number is even or odd
n = int(input("Enter a number: "))
if n % 2 == 1:
    print("Odd")
else:
    print("Even")

# Exercise 2: Find divisors of a number
n = int(input("Enter a number: "))
print("Divisors are: ")
for i in range(1, n + 1):
    if n % i == 0:
        print(i)

# Exercise 3: Sum of divisors
z = 0
n = int(input("Enter a number: "))
print("Sum of divisors is: ")
for i in range(1, n + 1):
    if n % i == 0:
        z += i
print(z)

# Exercise 4: Count the number of divisors
z = 0
n = int(input("Enter a number: "))
print("Number of divisors is: ")
for i in range(1, n + 1):
    if n % i == 0:
        z += 1
print(z)

# Exercise 5: Prime divisors
def is_prime(x):
    for i in range(2, x // 2 + 1):
        if x % i == 0:
            return False
    return True

n = int(input("Enter a number: "))
print("Prime divisors are: ")
for i in range(1, n + 1):
    if n % i == 0 and is_prime(i):
        print(i)

# Exercise 6: Twin primes (prime numbers that differ by 2)
def is_prime(x):
    for i in range(2, x // 2 + 1):
        if x % i == 0:
            return False
    return True

a = int(input("Enter the first number: "))
b = int(input("Enter the second number: "))
if is_prime(a) and is_prime(b) and abs(a - b) == 2:
    print("These numbers are twin primes.")

# Exercise 7: Check if a number is a perfect number (sum of divisors equals the number)
def sum_of_divisors(x):
    z = 0
    for i in range(1, x):
        if x % i == 0:
            z += i
    return z

a = int(input("Enter a number: "))
if a == sum_of_divisors(a):
    print("Yes")
else:
    print("No")

# Exercise 8: Check if two numbers are amicable numbers (sum of divisors of each equals the other)
def sum_of_divisors(x):
    z = 0
    for i in range(1, x):
        if x % i == 0:
            z += i
    return z

a = int(input("Enter the first number: "))
b = int(input("Enter the second number: "))
if a != b and sum_of_divisors(a) == b and sum_of_divisors(b) == a:
    print("They are amicable.")
else:
    print("They are not amicable.")

# Exercise 9: Find twin primes up to 998
def is_prime(x):
    for i in range(2, x // 2 + 1):
        if x % i == 0:
            return False
    return True

for i in range(3, 998):
    if is_prime(i) and is_prime(i + 2):
        print(i, "is a twin prime with", i + 2)

# Exercise 10: Print all perfect numbers up to 1000
def sum_of_divisors(x):
    z = 0
    for i in range(1, x):
        if x % i == 0:
            z += i
    return z

for i in range(1, 1000):
    if sum_of_divisors(i) == i:
        print(i)

# Exercise 11: Factorization of a number
n = int(input("Enter a number: "))
dzielnik = 2
while n > 1:
    while n % dzielnik == 0:
        print(dzielnik)
        n = n // dzielnik
    dzielnik += 1

# Exercise 12: Sum of factors
n = int(input("Enter a number: "))
dzielnik = 2
Suma = 0
while n > 1:
    while n % dzielnik == 0:
        Suma += dzielnik
        n = n // dzielnik
    dzielnik += 1
print(Suma)

# Exercise 13: Sum of factors of a number and check if the sum is prime
n = int(input("Enter a number: "))
dzielnik = 2
Suma = 0
while n > 1:
    while n % dzielnik == 0:
        Suma += dzielnik
        n = n // dzielnik
    dzielnik += 1
print(Suma)

def is_prime(x):
    for i in range(2, x // 2 + 1):
        if x % i == 0:
            return False
    return True

if is_prime(Suma):
    print("Yes")
else:
    print("No")

# Exercise 14: List distinct prime divisors
n = int(input("Enter a number: "))
T = []
dzielnik = 2
while n > 1:
    while n % dzielnik == 0:
        if dzielnik not in T:
            T.append(dzielnik)
        n = n // dzielnik
    dzielnik += 1
print(T)

# Exercise 15: Smith number check
def digit_sum(x):
    sum_digits = 0
    while x > 0:
        sum_digits += x % 10
        x = x // 10
    return sum_digits

n = int(input("Enter a number: "))
p = n
Suma = 0
dzielnik = 2
while n > 1:
    while n % dzielnik == 0:
        Suma += digit_sum(dzielnik)
        n = n // dzielnik
    dzielnik += 1
print(Suma)

suma2 = digit_sum(p)
print(suma2)

if Suma == suma2:
    print("It is a Smith number.")
