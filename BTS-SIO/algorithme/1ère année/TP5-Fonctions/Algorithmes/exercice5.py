from random import *
def creerliste():
    alea = []
    a = randint(1,20)
    b = randint(1,20)
    c = randint(1,20)
    d = randint(1,20)
    alea.append(a)
    alea.append(b)
    alea.append(c)
    alea.append(d)
    return alea

maListe = creerliste()
for i in range(0,len(maListe)):
    print(maListe[i])

def estCroissante(alea):
    for i in range(1,len(alea)):
        if alea[i-1] > alea[i]:
            print("Pas croissante")
            return False
    print("Est croissante")
    return True

estCroissante(maListe)

def estConsecutif(alea):
    for i in range(1,len(alea)):
        if alea[i-1]+1 != alea[i]:
            return False
    return True

#Algo_estDansLordre
#Variables
estTrie = True
cpt = 0
n = 0
#Traitement
if (estCroissante(maListe)) == False:
    while estTrie == True:
        estTrie = False
        cpt = cpt+1
        for j in range(0,len(maListe)-cpt):
            if maListe[j] > maListe[j+1]:
                estTrie = True
                maListe[j], maListe[j+1] = maListe[j+1], maListe[j]
                
print("Il aura fallu ",cpt," permutations pour que la liste soit triée par ordre croissant")
for i in range(0,len(maListe)):
    print(maListe[i])

if estConsecutif(maListe) == True:
    print("Les valeurs sont consécutives")
else:
    print("Les valeurs ne sont pas consécutives")
