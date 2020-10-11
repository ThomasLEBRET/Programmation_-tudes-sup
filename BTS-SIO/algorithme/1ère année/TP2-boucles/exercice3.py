# -*- coding: UTF-8 -*-

#Exercice 3
oeufs = int(input("Combien disposez-vous d'oeufs ?"))
boites = 0
for i in range (1, oeufs+1):
    if(oeufs>= 12):
        boites = boites + 1
        oeufs = oeufs -12
print("Le nombre de boites est :" ,boites)
print("Il reste ",oeufs," oeufs ne rentrant pas dans la boite ! ")
