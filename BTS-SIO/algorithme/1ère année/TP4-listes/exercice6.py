nom = ["Jean","Pierre","Maurice","Thomas","Steven","Najib",
       "Rayan","Michel","Yvette"]
plus6 = []
moins6 = []
for i in range(0,len(nom)):
    if len(nom[i]) > 6:
        plus6.append(nom[i])
    else:
        moins6.append(nom[i])
print(plus6[:])
print(moins6[:])
