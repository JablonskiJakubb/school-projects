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


t = [9, 4, 1, 3, 8, 7, 0, 6, 2, 5]


# the len of this table is 10
# therefore middle is 4  | 10 - 1 = 9 | 9 // 2 = 4
# left is t[:5] | values from the indexes 0 trough 5 of table t | left1_1 = [9,4,1,3,8]
# right is t[5:] | values from the indexes 5 through 10 (len of t) of table t | right_2_1 = [7,0,6,2,5]
# it begins to split up into two diffrent uses of the merge sort algorithm
# merge_sort(temp1) gives an output of next two temps until the len of both the temps is equal to 1
# then and only then it merges the temps one by one until all of them are one sorted table
# example below
# ---------------------------------------------------
# ms - merge_sort | l - left | r - right | ms_l_l - merge sort of the left part of the left part
# ---------------------------------------------------
# 9 4 1 3 8 7 0 6 2 5
# ms_l(9 4 1 3 8) | ms_r(7 0 6 2 5)
# ms_l-l(9 4) | ms_l-r(1 3 8)       ms_l-l = 4 9
# ms(9 4) = 4 9
# to be continued.
#

# --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



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
