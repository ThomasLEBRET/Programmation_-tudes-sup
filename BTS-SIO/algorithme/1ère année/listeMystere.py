import random

#Functions
def genereListeAlea():
    tab = []
    for i in range(6):
        a = random.randint(0,9)
        while(a in tab):
            a = random.randint(0,9)
        tab.append(a)
    return tab


def resListe(T, tab):
    res = [""]*6
    for i in range(6):
        if T[i] in tab:
            res[i] = "O"
            if T[i] == tab[i]:
                res[i] = "OO"
        else:
            res[i] = "X"
    return res

#Main
T = []
tab = genereListeAlea()
tour = 1
while T != tab:
    T = []
    print("Tour ",tour)
    print("Entrez 6 numéro différents")
    for i in range(6):
        a = int(input("Entrez le numéro"))
        while a in T:
            a = int(input("Entrez le numéro"))
        T.append(a)
    print(resListe(T,tab))
    tour = tour + 1

print("Bravo, vous avez trouvé toute la liste !")
