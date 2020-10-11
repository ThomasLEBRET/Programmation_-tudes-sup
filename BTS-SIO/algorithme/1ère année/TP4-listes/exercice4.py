t1 = [50,4,21,64,13,54,90,108,529,34,18,534,5,987]


pPetit = t1[0]
for i in range(0,len(t1)):
    if pPetit > t1[i]:
        pPetit = t1[i]
        posPetit = len(t1)-i


pGrand = t1[0]
for i in range(0,len(t1)):
    if pGrand < t1[i]:
        pGrand = t1[i]
        posGrand = len(t1)-i

cpt=  0
for i in range(0,len(t1)):
    if t1[i] == 0:
        cpt = cpt+1


print("Le plus grand est : ",pGrand, " en position ", posPetit, " dans le tableau.")
print("Le plus petit est : ",pPetit, " en position", posGrand, " dans le tableau.")
print("Il y a ",cpt," éléments null dans le tableau.")
