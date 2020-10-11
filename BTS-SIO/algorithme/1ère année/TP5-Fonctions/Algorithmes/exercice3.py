def echange(a,b):
    a, b = b, a
    return a,b
print(echange(4,8))

a = 4
b = 2
c = 12

if b < a:
    echange(a,b)
