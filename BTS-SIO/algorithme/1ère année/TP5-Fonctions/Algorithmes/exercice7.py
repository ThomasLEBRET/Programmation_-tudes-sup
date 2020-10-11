from random import *
def initialise():
    tab = []
    nbrItems = randint(1,99)
    for i in range(0,nbrItems):
        tab.append(randint(1,99))
    return tab

def maxTab(tab):
    valMax = 0
    for i in range(0,len(tab)):
        if tab[i] > valMax:
            valMax = tab[i]
    return valMax

def minTab(tab):
    valMax = 101
    for i in range(0,len(tab)):
        if tab[i] < valMax:
            valMin = tab[i]
    return valMin

def moyenneTab(tab):
    total = 0
    for i in range(0,len(tab)):
        total = total+tab[i]
    return total/len(tab)

tab = initialise()
print("Maximum : ",maxTab(tab))
print("Minimum : ",minTab(tab))
print("Moyenne : ",moyenneTab(tab))
