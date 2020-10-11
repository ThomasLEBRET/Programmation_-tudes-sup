# -*- coding: UTF-8 -*-

#Exercice 8

#1 et #2
moyenne = 0
note = 0
nHaute = 0
nBasse = 20
rep = 'O'
nbrNotes = 0
totalNotes = 0

while rep == 'O' and str(rep) != '99':
    note = float(input("Entrez une note"))
    if note < 0 or note > 20:
        print("La note n'est pas valide")
    else:
        if note > nHaute:
            nHaute = note
        if note < nBasse:
            nBasse =  note
        nbrNotes += 1
        totalNotes += note
    rep = input("Voulez-vous continuer (O/N)")
    while rep != 'O' and rep != 'N' and str(rep) != '99':
        rep = input("Vous n'avez pas rentré la bonne lettre (O/N)")
        
if nbrNotes != 0:
    moyenne = totalNotes/nbrNotes
print("La moyenne est de ",moyenne,"/20")
print("La note la plus haute est de ",nHaute,"/20")
print("La note la plus basse est de ",nBasse,"/20")
