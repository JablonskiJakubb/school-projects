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
# iteration
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
# recursion
def is_subsequence(s1: str, s2: str) -> bool:
    """
    Check if s1 is a subsequence of s2.

    Args:
    s1 (str): The string to check as a subsequence.
    s2 (str): The string to check against.

    Returns:
    bool: True if s1 is a subsequence of s2, False otherwise.
    """
    def helper(s1, s2, i, j):
        # Base case: If we've checked all characters of s1, it's a subsequence
        if i == len(s1):
            return True
        # Base case: If we've exhausted s2 without finding all characters of s1
        if j == len(s2):
            return False
        # Recursive case: Match the current character or skip in s2
        if s1[i] == s2[j]:
            return helper(s1, s2, i + 1, j + 1)
        else:
            return helper(s1, s2, i, j + 1)

    return helper(s1, s2, 0, 0)

# Examples for testing
print(is_subsequence("abc", "ahbgdc"))  # Output: True
print(is_subsequence("axc", "ahbgdc"))  # Output: False


