def matident(n):
    mat = [[0 for j in range (n)]for i in range(n)]
    for i in range(0,n):
        mat[i][i] = 1
    return mat
print(matident(3))
