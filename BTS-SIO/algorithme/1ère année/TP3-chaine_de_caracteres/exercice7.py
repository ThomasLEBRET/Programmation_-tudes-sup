a = input("Entrez une chaine de caractères")
b = ""
for i in range(0,len(a)):
    if a[i] == ".":
        b = b+"+"
    elif a[i] == "+":
        b = b+"."
    else:
        b = b + a[i]
print(b)
