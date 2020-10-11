# -*- coding: utf-8 -*-
from math import *
import datetime

# Question 1
a = 5+3
print(type(a)) #int

b=1.54
print(type(b)) #float

c = 18/3
print(type(c)) #float

d = 20.0/3
print(type(d)) #float

# Premier programme question 2

a,b,c = -1,25/4,3.45
print("Type de -1 :", type(a)) #int
d = input("Entrez la valeur de d :")
print("La valeur de d est :", type(d)) #string
e = int(input("Entrez la valeur de e :"))
print("La valeur de e est :", type(e)) #int

""" d est un string car on entre une chaine de caractère et Python prend en
compte dans ces cas là les caractères alphanumériques même si l'on
rentre un nombre entier, cela ne sera jamais un int dans ce cas

Si e = 5.3, on a un message d'erreur qui nous dit que la valeur littérale pour
un int en base 10 n'est pas valide
ValueError: invalid literal for int() with base 10: '5.3'
Si e=7, e sera un int sans message d'erreur

Rouge : Erreur brut du programme
Vert : Fichier + lignes exécutées avec succès ou erreur
Violet : Module (le programme)

Exercice 1 : Calcul périmètre """
choice = 0
while True:
    print("MENU")
    print("Perimetre d'un cercle (1)")
    print("Perimetre d'un carre (2)")
    print("Perimetre d'un triangle (3)")
    print("Perimetre d'un rectangle (4)")
    choice = int(input("Choisissez : "))
    if choice == 1 or choice == 2 or choice == 3 or choice == 4:
        break

if choice == 1:
    r = float(input("Entrez le rayon de votre cercle pour le calcul du perimetre : "))
    p = 2*pi*r
    print("Le perimetre de votre cercle est : ", p)

elif choice == 2:
    r = float(input("Entrez une longueur du carré pour le calcul du perimetre : "))
    p = 4*r
    print("Le perimetre de votre carré est : ", p)

elif choice == 3:
    print("Entrez les 3 longueurs de votre triangle pour le calcul du perimetre : ")

    a = float(input())
    b = float(input())
    c = float(input())

    p = a+b+c
    print("Le perimetre de votre triangle est : ", p)

else:
    print("Entrez la largeur et la longueur de votre rectangle pour le calcul du périmètre : ")
    l = float(input(l))
    L = float(input(L))
    print("Entrez la largeur et la longueur de votre rectangle pour le calcul du perimetre : ")
    l = float(input())
    L = float(input())
    p = 2*(l+L)
    print("Le perimetcre de votre carre est : ", p)

#Exercice 2 : Programmes exercice 3

name = raw_input("Entrez votre nom :")
dateBirth = int(input("Entrez votre annee de naissance : "))
dateYear = datetime.datetime.now().year
dateBirth = dateYear - dateBirth
print("Vous avez "+str(dateBirth)+" ans "+str(name))
print("Vous avez "+str(dateBirth)+" ans, "+str(name))

#Exercice 2 : Programmes exercice 4

pre = float(input("Entrez une valeur : "))
sec = float(input("Entrez une seconde valeur : "))

print("Addition : "+str(pre+sec)+" !")
print("Souostraction : "+str(pre-sec)+" !")
print("Multiplication : "+str(pre*sec)+" !")
print("Division : "+str(pre/sec)+" !")


#Exercice 3 : Racine carré

while True:
    r = float(input("Entrez la valeur dont vous voulez la racine : \n"))
    if r < 0:
        print("Votre valeur est negative, une racine carre n'accepte pas ça ! \n")
    elif r == 0 or r == 1:
        print("La valeur est : "+str(r)+" \n")
        break
    else:
        break
q = sqrt(r)
print("La valeur de "+str(r)+" est : "+str(q)+"\n")

#Exercice 4 :Algorithme mention

def mention(result):
    if result >= 0 or result <= 20:
        if result == 10:
            print("De justesse !\n")
        elif result > 10 and result < 12:
            print("Passable\n")
        elif result >= 12 and result < 14:
            print("Assez bien\n")
        elif result >= 14 and result < 16:
            print("Bien\n")
        elif result >= 16:
            print("Tres bien !\n")
        else:
            print("Redoublement !\n")
        return 0
mention(5) #Redoublement
mention(10) #De justesse
mention(11) #Passable
mention(12) #Assez bien
mention(13) #Assez bien
mention(15) #Bien
mention(16) #Très bien

#Exercice 5 : Algorithme photocopie

def photocopie(nbrPtc):
    max = 0.10;
    mid = 0.05;
    min = 0.03;
    result = 0
    if(nbrPtc <= 5 and nbrPtc > 0):
        result = nbrPtc*max
        return result
    elif(nbrPtc > 5 and nbrPtc <= 15):
        result = 5*max + (nbrPtc-5)*mid
        return result
    elif(nbrPtc > 15):
        result = 5*max + (15-5)*mid + nbrPtc*min
        return result
    else:
        return 0

photocopie(-4) #return 0
photocopie(0) #return 0
photocopie(4)
photocopie(5)
photocopie(10)
photocopie(15)
photocopie(16)
photocopie(25)
def copy(nbr_copy):
	primary_copy = 0.10
	middle_copy = 0.09
	next_copy = 0.08
	price = 0

	if nbr_copy <= 10:
		price = nbr_copy * primary_copy
	elif nbr_copy < 30:
		price = nbr_copy * primary_copy + (nbr_copy - 10) * middle_copy
	else:
		price  =  nbr_copy * primary_copy + 20 * middle_copy  + (nbr_copy - 30) * next_copy

	print("Le prix total est de : "+str(price)+"\n")

copy(3)
copy(12)
copy(21)
copy(35)
copy(55)
