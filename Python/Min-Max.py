# import random
# t = [random.randint(1,1000) for _ in range(1,100)]
# maximum = t[0]
# minimum = t[0]
# compare = 0
# for i in range(1,len(t)-1):
#     if maximum < t[i+1]:
#         maximum = t[i+1]
#         compare += 1
#     if minimum > t[i+1]:
#         minimum = t[i+1]
#         compare += 1
# print(minimum , maximum , compare)


# import random
# t = [random.randint(1,1000) for _ in range(1,100)]
# maximum = t[0]
# minimum = t[0]
# compare = 0
# if t[0]<t[1]:
#     minimum = t[0]
#     maksimum = t[1]
# else:
#     minimum = t[1]
#     maksimum = t[0]
# for i in range(2,len(t)-1,2):
#     if t[i]<t[i+1]:
#         if t[i] < minimum:
#             minimum = t[i]
#         if t[i+1] > maksimum:
#             maksimum = t[i+1]
#     else:
#         if t[i+1]<minimum:
#             minimum = t[i+1]
#         if t[i] > maksimum:
#             maksimum = t[i]
