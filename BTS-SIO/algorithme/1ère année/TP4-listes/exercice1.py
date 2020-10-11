from random import *

jours = ["Lundi","Mardi","Mercredi","Jeudi","Vendredi","Samedi","Dimanche"]
shuffle(jours)
tmp = ""

for j in range(0,len(jours)):
    for i in range(0,len(jours)):
        if jours[i][0:1] == "L":
            tmp = jours[i]
            jours[i] = jours[0]
            jours[0] = tmp
        if jours[i][0:2] == "Ma":
            tmp = jours[i]
            jours[i] = jours[1]
            jours[1] = tmp
        if jours[i][0:2] == "Me":
            tmp = jours[i]
            jours[i] = jours[2]
            jours[2] = tmp
        if jours[i][0:1] == "J":
            tmp = jours[i]
            jours[i] = jours[3]
            jours[3] = tmp
        if jours[i][0:1] == "V":
            tmp = jours[i]
            jours[i] = jours[4]
            jours[4] = tmp
        if jours[i][0:1] == "S":
            tmp = jours[i]
            jours[i] = jours[5]
            jours[5] = tmp
        if jours[i][0:1] == "D'":
            tmp = jours[i]
            jours[i] = jours[6]
            jours[6] = tmp
print(jours[:])
