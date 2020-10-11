import random
def matalea(n, p):
    if n <= 0 or p <= 0:
        print("Erreur, une des valeurs est négative !")
        return
    mat = [[random.randint(1,9) for j in range (p)]for i in range(n)]
    return mat

def matident(n):
    mat = [[0 for j in range (n)]for i in range(n)]
    for i in range(0,n):
        mat[i][i] = 1
    return mat

def somme(mat1,mat2):
    if len(mat1) != len(mat2):
        print("Erreur, les matrices n'ont pas le même nombre de lignes !")
        return
    elif len(mat1[0]) != len(mat2[0]):
        print("Erreur, les matrices n'ont pas le même nombre de colonnes !")
        return
    else:
        mat3 = matalea(len(mat1), len(mat1))
        for i in range(0,len(mat1)):
            for j in range(0, len(mat1[0])):
                mat3[i][j] = mat1[i][j] + mat2[i][j]
    return mat3

def prodreel(mat1,k):
    for i in range(0, len(mat1)):
        for j in range(0, len(mat1[0])):
            mat1[i][j] = k * mat1[i][j]
    return mat1

def prod(mat1,mat2):
    if len(mat1[0]) != len(mat2):
        print("Erreur, les matrices ne peuvent pas être multipliées !")
        return
    mat3 = []
    for i in range(0, len(mat1)):
        mat3.append([])
        for j in range(0, len(mat2[0])):
            mat3[i].append(0)
            for k in range(len(mat2)):
                mat3[i][j] += mat1[i][k] * mat2[k][j]
    return mat3

ordre1 = int(input("Choisissez le nombre de lignes de votre matrice :"))
ordre2 = int(input("Choisissez le nomrbed de colonnes de votre matrice :"))
if ordre1 <= 1 or ordre2 <= 2:
    ordre1 = int(input("Choisissez le nombre de lignes de votre matrice :"))
    ordre2 = int(input("Choisissez le nomrbed de colonnes de votre matrice :"))


choixMat = int(input("Choisissez la matrice a entrer dans le programme :"))

mat1 = matalea(ordre1, ordre2)
mat2 = matalea(ordre1, ordre2)

print("Addition (1)")
print("Multiplication avec un facteur (2)")
print("Multiplication entre 2 matrices (3)")
choix = int(input("Choisissez le type d'opération à réaliser :"))
if choix == 1:
    print(mat1 + mat2)
elif choix == 2:
    k = int(input("Choisissez un coefficient entier >= 1 :"))
    if k <= 1:
        k = int(input("Choisissez un coefficient entier >= 1 :"))
    print(prodreel(mat1, k))
elif choix == 3:
    print(prod(mat1, mat2))
