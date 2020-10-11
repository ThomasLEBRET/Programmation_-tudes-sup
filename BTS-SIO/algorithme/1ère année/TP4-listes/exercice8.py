tab = [50,4,21,64,13,54,90,108,529,34,18,534,5,987]
tab2 = []
for i in range(0,len(tab)):
    tab2.append(tab[len(tab)-i-1])
print(tab2[:])
tab2.reverse()
print(tab2[:]) #pour vérifier 
print(tab[:])
