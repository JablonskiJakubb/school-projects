def get_subsequence(string):
    """
    Generate a subsequence of the given string by selecting characters at even indices.
    
    Parameters:
        string (str): The input string.
    
    Returns:
        str: The subsequence formed by characters at even indices.
    """
    subsequence = ""
    for i in range(len(string)):
        if i % 2 == 0:  # Select characters at even indexes
            subsequence += string[i]
    return subsequence

# Example usage
input_string = "abcdef"
result = get_subsequence(input_string)
print(f"Input string: {input_string}")
print(f"Subsequence: {result}")

#------------------------------------------------------------------------------------------------------------
# exercises
#------------------------------------------------------------------------------------------------------------
# Exercise: Longest Increasing Continuous Subsequence (LICS)

def LICS(num):
    max = 0
    result = 0
    for i in range(len(num)):
        for j in range(i,len(num)):
            if num[i] <= num[j]:
                max += 1
            if num[j-1] > num[j]:
                max -= 1
        if result < max:
            result = max
        max = 0
    return result

# Example usage
num = [10, 9, 2, 5, 3, 7, 101, 18]
print(LICS(num))
# Output: 3


# Exercise: Check If Is Subsequence
def check_if_subsequence(s, t):
    index = 0
    for char in s:
        # Find the character in 't' starting from the current index
        while index < len(t) and t[index] != char:
            index += 1
        # If we reach the end of 't' without finding the character, return False
        if index == len(t):
            return False
        # Move to the next character in 't' for the next iteration
        index += 1
    return True


