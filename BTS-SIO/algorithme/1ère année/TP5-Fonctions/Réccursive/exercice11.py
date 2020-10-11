def divisionPGCD(a,b):
    if b == 0:
        return a
    else:
        return divisionPGCD(b,a%b)

def soustractionPGCD(a,b):
    
    return a

print(divisionPGCD(56,42))
print(soustractionPGCD(56,42))
