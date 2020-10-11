tab = ["L","A","V","A","L"]
tab2 = []
mot = ""
def creerMot(tab):
    mot = ""
    for i in range(0,len(tab)):
        mot = mot+tab[i]
    return mot
def faitInverse(tab):
    tab2 = []
    for i in range(0,len(tab)):
        tab2.append(tab[len(tab)-i-1])
    return tab2
mot = creerMot(tab)
mot2 = creerMot(faitInverse(tab))
if mot == mot2:
    print("Palaindrome !")
else:
    print("Pas palindrome !")
