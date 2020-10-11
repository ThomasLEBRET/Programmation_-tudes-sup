#Algo_programme_principal
#Variables
secret = input("Le joueur 1 rentre un mot secret") #string
essai = 1 #int
r = False #bool
trouve = 0 #int
reste = len(secret) #int
#Traitement
while essai <= 10 and reste != 0:
    lettre = input("Joueur 2 entre une lettre\n")
    for i in range(0,len(secret)):
        if secret[i] == lettre:
            r = True
            trouve = trouve+1
    reste = len(secret)-trouve
    if r == True:
        print("La lettre fait partie du mot, il reste ",reste," lettre(s) dans le mot")
    else:
        print("La lettre ne fait pas partie du mot, il reste ",reste, " lettre(s) dans le mot")
    r = False
    essai = essai+1
if reste == 0:
    print("Le joueur 2 a gagné")
else:
    print("Le joueur 1 a gagné")
#Fin
