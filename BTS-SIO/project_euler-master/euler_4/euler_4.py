def is_palindrome(nb):
    if str(nb) == str(nb)[::-1]: #Nombre converti en chaine de caractere et on regarde si la chaine inverse est identique a celle d'origine
        return True
    return False
    
resultat = 0
for i in range(100, 1000):
    for j in range(i, 1000):
        produit = i*j
        #Test si le produit est un palindrome
        if is_palindrome(produit):
            if produit > resultat:
                resultat = produit
print(resultat)
