# -*- coding: UTF-8 -*-

#Exercice 9

#1 et 2
n = 1.0
Sn = 0.0
sn = int(input("Entrez un nombre (suite Sn) :"))
while(n <= sn):
    Sn = Sn + 1/n
    n = n+1
print(Sn)

#3
sn = 0.0
n = 1.0
A = int(input("Entrez un nombre (Sn > A) :"))
while (sn < A):
    sn = sn + 1/n
    n = n+1
print("La plus petite valeur i pour laquelle Sn > A est :", n, " pour la valeur sn : ", sn)
