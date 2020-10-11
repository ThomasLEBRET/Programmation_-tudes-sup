import random

def afficheMat(mat):
    for i in range(len(mat)):
        print(mat[i])

def rempli_alea(n):
    mat = matnull(n)
    for i in range(len(mat)):
        for j in range(len(mat)):
            mat[i][j] = random.randint(0,1)
    return mat

def transposeMatrice(mat):
    return [[col[i] for col in mat] for i in range(len(mat))]
    


mat = rempli_alea(6)
afficheMat(mat)
print("\n")
mat = transposeMatrice(mat)
afficheMat(mat)
