a = input("Entrez une chaine de caractères")
b = a[0]
for i in range(1,len(a)):
    b = b+"*"+a[i]
print(b)
