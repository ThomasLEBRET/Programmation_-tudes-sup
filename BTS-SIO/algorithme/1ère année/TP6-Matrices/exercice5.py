import random
def matalea(n, p):
    if n <= 0 or p <= 0:
        print("Erreur, une des valeurs est négative !")
        return
    mat = [[random.randint(1,9) for j in range (p)]for i in range(n)]
    return mat

mat1 = matalea(3,3)
mat2 = matalea(3,3)
mat3 = matalea(2,5)

    
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
    
print(somme(mat1, mat2))
