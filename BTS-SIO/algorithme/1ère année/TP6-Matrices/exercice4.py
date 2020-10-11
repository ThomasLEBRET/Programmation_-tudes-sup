import random
def matalea(n, p):
    if n <= 0 or p <= 0:
        print("Erreur, une des valeurs est négative !")
        return
    mat = [[random.randint(1,9) for j in range (p)]for i in range(n)]
    return mat
print(matalea(3, 4))
