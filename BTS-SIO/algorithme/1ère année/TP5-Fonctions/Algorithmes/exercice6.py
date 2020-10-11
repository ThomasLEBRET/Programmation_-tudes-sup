def capital(emprunt, duree, taux):  
    arendre = 1
    for i in range(0,duree):
        arendre = arendre*(1-taux)
    arendre = arendre*emprunt
    return arendre

def capRestant(rembourser, mensualite, nbrMens):
    return rembourser - mensualite*nbrMens

emprunt = float(input("Votre emprunt :"))
duree = int(input("Votre durée d'emprunt"))
taux = float(input("Votre taux d'emprunt"))
rembourser = capital(emprunt,duree,taux)
mensualite = rembourser / (3*12)

print("Il vous rendre ",rembourser," à rembourser")
print("Vos mensualités sont élevées à ",mensualite)

choix = int(input("Voulez-vous voir le capital restant à rembourser ? (tapez 1 si oui)"))
if choix == 1:
    nbrMens = int(input("Combien de mensualités avez-vous déjà versé ?"))
    reste = capRestant(rembourser,mensualite,nbrMens)
    print(reste)

