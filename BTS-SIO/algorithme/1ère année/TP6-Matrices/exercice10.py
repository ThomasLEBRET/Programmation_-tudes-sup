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

def damier(n):
    mat = matnull(n)
    for i in range(len(mat)):
        for j in range(len(mat)):
            if i%2 == 0 and j%2 == 1:
                mat[j][i] = 1
            elif i%2 == 1 and j%2 == 0:
                mat[j][i] = 1
                
    return mat

n = int(input("Choisissez le rang de votre damier"))
if n < 1:
    print("Le rang de la matrice ne peut pas etre nul ou négatif")
    n = int(input("Choisissez le rang de votre matrice n (carree) "))

mat = damier(n)
afficheMat(mat)
