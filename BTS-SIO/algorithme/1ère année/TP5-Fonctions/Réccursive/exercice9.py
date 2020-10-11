def factoriel(x):
    if x < 2:
        return 1
    return x*factoriel(x-1)

print(factoriel(10))
