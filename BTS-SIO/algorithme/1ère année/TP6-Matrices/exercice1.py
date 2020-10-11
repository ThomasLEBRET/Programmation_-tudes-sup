def creerMatrice(n,p):
    mat = []
    for i in range(0,n):
        mat.append([])
        for j in range(0,p):
            mat[i].append(0)
    return mat

def creerMatriceDeux(n,p):
    return [[0 for j in range (n)]for i in range(p)]
mat = creerMatrice(3,3)
mat2 = creerMatriceDeux(3,3)
print(mat)
print(mat2)
