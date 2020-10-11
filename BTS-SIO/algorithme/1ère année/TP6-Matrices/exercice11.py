import random
def matnull(n):
    mat = []
    for i in range(0,n):
        mat.append([])
        for j in range(0,n):
            mat[i].append(0)
    return mat

def afficheMat(mat):
    for i in range(len(mat)):
        print(mat[i])

def rempli_alea(n):
    mat = matnull(n)
    for i in range(len(mat)):
        for j in range(len(mat)):
            mat[i][j] = random.randint(0,1)
    return mat

def test(mat):
    for i in range(len(mat)):
        for j in range(len(mat)):
            if mat[j][i] == 0:
                return False
    return True

n = int(input("Choisissez le rang de votre damier"))
if n < 1:
    print("Le rang de la matrice ne peut pas etre nul ou négatif")
    n = int(input("Choisissez le rang de votre matrice n (carree) "))
cpt = 1
mat = rempli_alea(n)
while test(mat) == False:
    mat = rempli_alea(n)
    cpt = cpt+1
print("Il aura fallu ", cpt, " essais avant d'obtenir cette matrice")
afficheMat(mat)
