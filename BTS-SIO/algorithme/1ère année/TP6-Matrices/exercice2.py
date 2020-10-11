def matnull(n):
    mat = []
    for i in range(0,n):
        mat.append([])
        for j in range(0,n):
            mat[i].append(0)
    return mat
print(matnull(3))
