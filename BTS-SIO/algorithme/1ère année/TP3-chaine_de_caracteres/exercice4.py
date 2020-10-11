a = input("Entrez une chaine de caractères :")
b = ""
for i in range(0,len(a)):
        b = b+a[len(a)-i-1]
print(b)
