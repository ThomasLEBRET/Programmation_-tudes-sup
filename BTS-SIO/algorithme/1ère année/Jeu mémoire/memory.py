import random


def matnull():
    n = int(input("Entrez la largeur n du plateau"))
    p = int(input("Entrez la longuer p du plateau"))
    while n <= 0 or p <= 0 or n > 10 or p > 10 or (n*p)%2 != 0:
        print("Erreur, les dimensions ne sont pas correctes !")
        n = int(input("Entrez la largeur n du plateau"))
        p = int(input("Entrez la longueur p du plateau"))
    mat = [[0 for j in range (p)]for i in range(n)]
    return mat


def creerPlateau():
    mat = matnull()
    T = []
    n = int(len(mat))
    p = int(len(mat[0]))
    for i in range(int((n*p)/2)):
        T.append(int(i))
    T = T*2
    T.sort()
    l = len(T)
    for i in range(len(mat)):
        for j in range(len(mat[0])):
            alea = T[random.randint(0,len(T)-1)]
            mat[i][j] = alea
            T.remove(alea)
    return mat


def afficheMatFini(mat):
    for i in range(len(mat)):
        print(mat[i])

def posX(mat):
    n = int(input("Entrez la position en abscisse de la carte à retourner"))
    while n < 0 or n > len(mat):
        n = int(input("Entrez la position en abscisse de la carte à retourner"))
    return n

def posY(mat):
    n = int(input("Entrez la position en ordonnée de la carte à retourner"))
    while n < 0 or n > len(mat[0]):
        n = int(input("Entrez la position en ordonnée de la carte à retourner"))
    return n


def retourneCarte(mat, trouve, C1, C2):
    n = 0
    k = 0
    for i in range(len(mat)):
        for j in range(len(mat[0])):
            if len(trouve) != 0:
                if trouve[k-1] == mat[i][j]:
                    print(mat[i][j], end = " ")
                    k = k + 1
                    continue
            if mat[C1[0]-1][C1[1]-1] == mat[C2[0]-1][C2[1]-1] and (C1[0] != C2[0] or C1[1] != C2[1]) and n == 0:
                trouve.append(mat[C1[0]-1][C1[1]-1])
                trouve.append(mat[C2[0]-1][C2[1]-1])
                n = 1
            if i == C1[0]-1 and j == C1[1]-1:
                print(mat[C1[0]-1][C1[1]-1], end = " ")
            elif i == C2[0]-1 and j == C2[1]-1:
                print(mat[C2[0]-1][C2[1]-1], end = " ")
            else:
                print("*", end = " ")
        print("\n")
    return trouve

def estPartieFini(trouve, mat):
    trouve.sort()
    mat.sort()
    if len(trouve) == len(mat)*len(mat[0]) and len(trouve) > 0:
        return True
    return False
