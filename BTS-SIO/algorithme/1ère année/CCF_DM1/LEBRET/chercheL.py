#Algo_chercheL
#Variables
m = input("Entrez une chaine de caractères") #string
k = input("Entrez une lettre") #string
L = len(m) #int
reponse = False #bool
#Traitement
for i in range(0,L):
    if m[i] == k:
        reponse = True
print(reponse)
#Fin
