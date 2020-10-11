n = 0
a = input("Rentrez une chaine de caracteres : ")
for i in range(0,len(a)):
	if a[i] == "n":
		n = n+1
if n != 0:
	print("Il y a ",n," fois n dans cette chaine !")
