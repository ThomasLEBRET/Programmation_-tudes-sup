def multipleTrois(n):
    if n  == 1:
        return 3
    return 3*n + multipleTrois(n-1)

def sommeCarre(n):
    if n == 0:
        return 0
    return n*n + sommeCarre(n-1)

print(multipleTrois(6))
print(sommeCarre(8))
