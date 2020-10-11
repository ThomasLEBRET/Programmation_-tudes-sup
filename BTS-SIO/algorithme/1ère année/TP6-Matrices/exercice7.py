import random
def matalea(n, p):
    if n <= 0 or p <= 0:
        print("Erreur, une des valeurs est négative !")
        return
    mat = [[random.randint(1,9) for j in range (p)]for i in range(n)]
    return mat

mat1 = matalea(5,3)
mat2 = matalea(3,2)

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

print(prod(mat1, mat2))
