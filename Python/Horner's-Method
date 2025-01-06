def horner(poly, n, x):
    result = poly[0]
    # this takes the coefficient of our polynomial
    # in this case 2
    for i in range(1, n):
        # this loop repeats the number of times of coefficients present
        # this case 4
        result = result * x + poly[i]
        print(result)
        # here it turns the polynomial into a more nested form
        # the iretaions of the loop would therefore make the result equal to:
        #--------------------------------------------------------------------
        # (2 * x * -6) (i = 1)
        # ((2 * x * -6) * x + 2) (i = 2)
        # ((2 * x * -6) * x + 2) * x -1
        #--------------------------------------------------------------------
        # simply placing the value of x in its place we get the result
        #--------------------------------------------------------------------
        # ((2 * 3 + -6) * 3 + 2) * 3 - 1
        # ((6 - 6) * 3 + 2) * 3 - 1
        # 2 * 3 - 1
        # 6 - 1 = 5
        #---------------------------------------------------------------------


# Read coefficients for the polynomial
user_input = input("Enter polynomial coefficients separated by spaces: ")
poly = list(map(int, user_input.split()))

# Get the number to evaluate the polynomial
x = int(input("Enter the value at which the polynomial is evaluated: "))

# Calculate and print the result
n = len(poly)
print("Value of the polynomial:", horner(poly, n, x))
