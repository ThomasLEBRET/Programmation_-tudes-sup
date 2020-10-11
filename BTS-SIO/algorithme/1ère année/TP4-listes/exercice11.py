mot = ['c','h','a','t']
phrase = ['Je','suis','un','chat']
def creeMot(mot):
    word = ""
    for i in range(0,len(mot)):
        word = word + mot[i]
    return word

word = creeMot(mot)
print(word)
cpt = 0
for i in range(0,len(phrase)):
    if phrase[i] == word:
        cpt = cpt+1
if cpt > 0:
    print("Le mot ",word," existe ",cpt," fois")
else:
    print("Le mot ",word," n'existe pas ")
