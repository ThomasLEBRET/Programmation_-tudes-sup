import random
from memory import *

trouve = []
T = creerPlateau()
nbTour = 1
C1 = [0,0]
C2 = [0,0]
X1 = C1[0]
Y1 = C1[1]
X2 = C2[0]
Y2 = C2[1]
while nbTour <= 20 and not(estPartieFini(trouve, T)):
    print("Tour : ", nbTour)
    
    print("Carte 1 :")
    C1[0] = posX(T)
    C1[1] = posY(T)
    X1 = C1[0]
    Y1 = C1[1]
    if len(trouve) > 0:
            if T[X1][Y1] in trouve:
                C1[0] = posX(T)
                C1[1] = posY(T)
                X1 = C1[0]
                Y1 = C1[1]
    trouve = retourneCarte(T, trouve, C1, C1)
    
    print("Carte 2 :")
    C2[0] = posX(T)
    C2[1] = posY(T)
    X2 = C2[0]
    Y2 = C2[1]
    while C1 == C2:
        if len(trouve) > 0:
            if T[X1][Y1] in trouve or T[X2][Y2] in trouve:
                C2[0] = posX(T)
                C2[1] = posY(T)
                X2 = C2[0]
                Y2 = C2[1]
    trouve = retourneCarte(T, trouve, C1, C2)
    nbTour = nbTour + 1
    print(trouve)

if nbTour >= 20:
    print("Vous avez échoué !")
else:
    print("Bravo, vous avez tout trouvé !")
