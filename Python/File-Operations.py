#----------
# basics
#----------

# Reading data from a file
t = []
with open("sequences.txt", 'r') as file:
    for line in file:
        line = line.strip()
        t.append(line)
file.close()

# Writing a list into to a file
lines = ["First line", "Second line", "Third line"]

# Open the file and write the list of lines
with open("output.txt", "w") as file:
    file.writelines(f"{lines} ")

#-----------
# exercises
#-----------

# Exercise 1
first_name = input("Enter your first name: ")
last_name = input("Enter your last name: ")

with open("personal_data.txt", "w") as file:
    file.write(first_name + "\n")
    file.write(last_name + "\n")

print("Data has been saved.")

# Exercise 2

with open("personal_data.txt", "r") as file:
    first_name = file.readline().strip()
    last_name = file.readline().strip()

print(f"Hello {first_name} {last_name}!")

# Exercise 3
import random

with open("random_numbers.txt", "w") as file:
    for _ in range(10):
        number = random.randint(1, 100)
        file.write(str(number) + "\n")

with open("random_numbers.txt", "r") as file:
    numbers = [int(line.strip()) for line in file]

sum_of_numbers = sum(numbers)
minimum = min(numbers)
maximum = max(numbers)
average = sum_of_numbers / len(numbers)

print(f"Sum: {sum_of_numbers}")
print(f"Minimum: {minimum}")
print(f"Maximum: {maximum}")
print(f"Average: {average}")

# Exercise 4
def Count_Even_Sum_Sequences(filename):
    with open(filename, 'r') as file:
        count = 0
        for line in file:
            numbers = list(map(int, line.split()))
            total_sum = sum(numbers)
            if total_sum % 2 == 0:
                count += 1
        return count

filename = 'sequences.txt'
result = Count_Even_Sum_Sequences(filename)
print(f'Number of sequences with an even sum of elements: {result}')

# Exercise 5
def Show_Numbered_Words(filename):
    with open(filename, 'r') as file:
        words = file.read().split()
        for index, word in enumerate(words, start=1):
            print(f'{index}: {word}')
filename = 'words.txt'
Show_Numbered_Words(filename
