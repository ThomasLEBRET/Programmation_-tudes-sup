mat = [[1,2,3],[4,5,6]]
#Ici, mat[1] donnera [4,5,6] parce que accède à, la 2eme ligne du tableau
print(mat[1])
#mat[1][2] donnera du coup 6 car on accède à  la 2eme ligne
#du tableau et à la 3eme case de la ligne
print(mat[1][2])

n = len(mat) # = 2
p=len(mat[0]) # =3
print(n) #nombre de lignes d'une matrice
print(p) #nombre de coefficient d'une ligne de la matrice

for ligne in mat:
    print(ligne)

