def algo_euclide(a,b):
    if b == 0:
        return a
    return algo_euclide(b, a%b)

print(algo_euclide(8753, 147))
    
def euclide(a,b):
    while b != 0:
        tmp = b
        b = a%b
        a = tmp
    return a

print(euclide(8753, 147))

def euclide_original(a,b):
    while a != b:
        if a > b:
            a = a - b
        else:
            b = b - a
    return a

print(euclide_original(8753,147))

