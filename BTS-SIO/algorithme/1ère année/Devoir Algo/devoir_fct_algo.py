#Cette fonction ne sert que pour mes tests
def afficherNotes(L):
    for i in range(0, len(L)):
        print(L[i])

def choisiNotes(N):
    listeNotes = []
    cpt = 0
    while cpt != N:
        note = float(input("Entrez une note :"))
        while note < 0 or note > 20:
            print("La note n'est pas comprise entre 0 et 20 !")
            note = float(input("Entrez une note :"))
        listeNotes.append(note)
        cpt = cpt + 1
    return listeNotes

def moyenneNotes(L):
    total = 0
    for i in range(0,len(L)):
        total = total + L[i]
    moyenne = total / len(L)
    return (moyenne,max(L),min(L))

def notesInferieurADix(L):
    cpt = 0
    for i in range(0, len(L)):
        if L[i] < 10 :
            cpt = cpt + 1
    return cpt


N = int(input("Choisissez le nombre de notes à rentrer svp :"))
L = choisiNotes(N)
print("La moyenne de la classe est à : ", moyenneNotes(L)[0])
print("La plus grande note de la classe est à : ", moyenneNotes(L)[1])
print("La plus petite note de la classe est à : ", moyenneNotes(L)[2])
etendue = moyenneNotes(L)[1] - moyenneNotes(L)[2]
print("L'étendue des notes de la classe est à : ", etendue)
print("le nombre de notes en-dessous de la moyenne est de : ", notesInferieurADix(L))
