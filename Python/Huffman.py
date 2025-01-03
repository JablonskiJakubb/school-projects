W = "TTTEEEECCCCCHHNIIIKK"
W = W + " "
count = 1
H = ""
for i in range(len(W) - 1):
    if W[i] == W[i + 1]:
        count += 1
    else:
        if count > 1:
            H += str(count)
        H += W[i]
        count = 1
print(H)
