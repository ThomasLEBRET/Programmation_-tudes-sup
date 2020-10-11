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
    

def cadre(n):
    mat = matnull(n)
    for i in range(len(mat)):
        mat[0][i] = 1
        mat[i][0] = 1
        mat[i][len(mat)-1] = 1
        mat[len(mat)-1][i] = 1
    return mat

n = int(input("Choisissez le rang de votre matrice n (carree) "))
if n < 1:
    print("Le rang de la matrice ne peut pas etre nul ou négatif")
    n = int(input("Choisissez le rang de votre matrice n (carree) "))

mat = cadre(n)
afficheMat(mat)
