def estPremier(a):
    for i in range(2,a-1):
        if a%i == 0:
            return False
    return True

n = int(input("Entrez un nombre pour vérifier si il est premier"))
if estPremier():
    print("Est premier")
else:
    print("Pas premier")
