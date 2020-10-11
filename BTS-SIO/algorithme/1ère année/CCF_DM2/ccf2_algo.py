def trouver_rang(caract):
    liste = ['I', 'V', 'X', 'L', 'C', 'D', 'M']
    rang = 1
    for i in range(0,7):
        if caract == liste[i]:
            rang = i
    return rang

def calcul_somme(S, rang, ch):
    liste = [1, 5, 10, 50, 100, 500, 1000]
    if i < len(ch)-1 and liste[rang] < liste[trouver_rang(ch[i+1])]:
        S = S - liste[rang]
    else:
        S = S + liste[rang]
    return S

def verifie_nbr_romain(nbr_romain, longueur):
    liste = ['I', 'V', 'X', 'L', 'C', 'D', 'M']
    for i in range(0, longueur):
        if nbr_romain[i] not in liste:
            return False
    return True


nb_rom = input("Saisir un nombre romain")
longueur = len(nb_rom)
nb_decimal = 0
if verifie_nbr_romain(nb_rom, longueur) == False:
    print("Le nombre romain n'est pas valide")
else :
    for i in range(0, longueur):
        rang = trouver_rang(nb_rom[i])
        nb_decimal = calcul_somme(nb_decimal, rang, nb_rom)
    print(nb_decimal)
