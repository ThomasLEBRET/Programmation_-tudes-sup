def retournerMax(a,b):
    if a > b:
        return a
    return b

print(retournerMax(3,2))
print(retournerMax(4,9))

def sommeEntiers(m,n):
    k = 0
    cpt = m
    for i in range(0,(n-m)+1):
        k = k+m+i
    return k

print(sommeEntiers(5,10))
