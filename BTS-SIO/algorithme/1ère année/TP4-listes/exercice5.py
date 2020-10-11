t1 = [50,4,21,64,13,54,90,108,529,34,18,534,5,987]
paire = []
impaire = []
    
for i in range(0,len(t1)):
    if t1[i]%2 == 0:
        paire.append(t1[i])
    else:
        impaire.append(t1[i])
del t1[:]
print(impaire[:])
print(paire[:])
print(t1[:])
