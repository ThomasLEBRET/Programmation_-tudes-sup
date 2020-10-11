tab = [10,20,30,40,10,30,50,60,70,50,80,53,90,10,10]
tabSave = tab
i,j,n = 0,0,0
#print([(i, tab.count(i)) for i in set(tab)])
while i < len(tab):
    while j < len(tab):
        if tab[i] == tab[j]:
            n = n+1
        j = j+1
    if n > 1:
        print("Il existe, pour la valeure ",tab[i],",",n," fois cette valeur")
        tab.remove(tab[i])
    
    n = 0
    i = i+1
    j = 0
