import random
def matalea(n, p):
    if n <= 0 or p <= 0:
        print("Erreur, une des valeurs est négative !")
        return
    mat = [[random.randint(1,9) for j in range (p)]for i in range(n)]
    return mat

mat1 = matalea(3,3)

def prodreel(mat1,k):
    for i in range(0, len(mat1)):
        for j in range(0, len(mat1[0])):
            mat1[i][j] = k * mat1[i][j]
    return mat1
    
print(prodreel(mat1, 2))
