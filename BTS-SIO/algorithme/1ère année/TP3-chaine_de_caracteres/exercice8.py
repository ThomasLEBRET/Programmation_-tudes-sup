#Exercice 8
#Algo_triangle_etoile

#Variables
n = int(input("Entrez le nombre de ligne que vous souhaitez pour votre triangle d'étoile"))
choix = int(input("Sélectionnez votre motif (1,2 ou 3)"))
#Traitement
while choix != 1 and choix != 2 and choix !=3:
    print("Le motif n'est pas reconnu")
    choix = int(input("Sélectionnez votre motif (1,2 ou 3)"))

if choix == 1:
    for i in range(1,n+1):
        print(i*"*")
elif choix == 2:
    for i in range(1,n+1):
        print((n-i)*"*")
elif choix == 3:
    for i in range(0,n):
        print((n-i)*" ",((2*i)+1)*"*")
#Fin
