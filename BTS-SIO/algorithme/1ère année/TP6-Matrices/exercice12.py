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
            mat[i][j] = random.randint(0,6)
    return mat

def coteACote(mat):
    L = []
    R = []
    for i in range(0,len(mat)):
        for j in range(0,len(mat)):
            L.append(mat[i][j])
        l = L[:]
        a = l[0]
        del(l[0])
        l.append(a)
        for k in range(0, len(l)):
            R.append(L[k] - l[k])
        for y in range(len(R)):
            if y+1 < len(R):
                if R[y] == 0 and R[y+1] == 0:
                    return True
        l[:] = []
        L[:] = []
        R[:] = []
    return False

def transposeMatrice(mat):
    return [[col[i] for col in mat] for i in range(len(mat))]

def coteACoteColonne(mat):
    mat = transposeMatrice(mat)
    return coteACote(mat)

def suite(mat):
    K = [1,2,3,4,5,6,7,8,9]
    L = []
    for i in range(len(mat)):
        for j in range(len(mat[i])):
            L.append(mat[i][j])
    dif = [item for item in K if item not in L]
    inter = ([item for item in K if item not in dif])
    for i in range(len(inter)):
        if i+1 != inter[i]:
            return False
    return True

mat = [[10,11,12], [1,2,3], [4,5,6], [7,8,9] ]
matDeux = [[10,11,12], [1,2,3], [4,76,6], [7,8,9] ]
if suite(mat):
    print("La série 1,2,3,4,5,6,7,8,9 existe dans la matrice !")
else:
    print("La série 1,2,3,4,5,6,7,8,9 n'existe pas dans la matrice !")

if suite(matDeux):
    print("La série 1,2,3,4,5,6,7,8,9 existe dans la matrice !")
else:
    print("La série 1,2,3,4,5,6,7,8,9 n'existe pas dans la matrice !")
        
print(mat)
print(matDeux)

n = int(input("Choisissez le rang de votre damier"))
mat = rempli_alea(n)
afficheMat(mat)

if coteACote(mat) == True:
    print("Il y a 3 chiffres côtes à côtes sur la même ligne")
else:
    print("Il n'y a pas 3 chiffres de chiffres côtes à côtes sur la même ligne")

if coteACoteColonne(mat) == True:
    print("Il y a 3 chiffres côtes à côtes sur la même colonne")
else:
    print("Il n'y a pas 3 chiffres de chiffres côtes à côtes sur la même colonne")




        
