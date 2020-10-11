m = input("Entrez une chaine de caractère")
k = input("Entrez une lettre")
L = len(m)
reponse = ""

for i in range(0,L):
    if m[i] == k:
        reponse = reponse+str(i+1)+";"
print(reponse)
