def merge(t1, t2):
    result = []
    n1 = len(t1)
    n2 = len(t2)
    i = 0
    j = 0
    while i < n1 and j < n2:
        if t1[i] < t2[j]:
            result.append(t1[i])
            i += 1
        else:
            result.append(t2[j])
            j += 1
    result.extend(t1[i:])
    result.extend(t2[j:])
    return result

# while i < n1 and j < n2:
#         if t1[i] < t2[j]:
#             result.append(t1[i])
#             i += 1
#         else:
#            result.append(t2[j])
#             j += 1
# should the value on t1[0] be smaller than the value on t2[0] it adds the value of t1[0] to the result
# next it compares t1[1] to t2[0]
# in case if t2[0] being smaller than t1[0] its the other way around
# it would next compare t1[0] to t2[1]

def merge_sort(t):
    n = len(t)
    if n > 1:
        middle = (n-1) // 2
        left = merge_sort(t[:middle+1])
        right = merge_sort(t[middle+1:])
        return merge(left, right)
    return t

# Input sequence from the user
sequence = input("Enter a sequence: ")
t = list(map(int, sequence.split()))
print(t)
t = merge_sort(t)
print(t)

# Reading data from a file
t = []
with open("sequences.txt", 'r') as file:
    for line in file:
        line = line.strip()
        t.append(line)
file.close()

# Writing results to a file
with open("results.txt", "w") as file:
    for i in range(len(t) - 1):
        result = merge_sort(t[i])
        file.write(" ".join(map(str, result)))

# Generating a list of random numbers
import random
random_numbers = [random.randint(1, 1000000) for _ in range(1000000)]

# Sorting the numbers using merge sort
sorted_numbers = merge_sort(random_numbers)

# Writing the sorted numbers to a new file
with open('results_3.txt', 'w') as file:
    for number in sorted_numbers:
        file.write(f"{number}\n")
