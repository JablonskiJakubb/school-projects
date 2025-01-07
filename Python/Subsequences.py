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
        if i % 2 == 0:  # Select characters at even indices
            subsequence += string[i]
    return subsequence

# Example usage
input_string = "abcdef"
result = get_subsequence(input_string)
print(f"Input string: {input_string}")
print(f"Subsequence: {result}")
