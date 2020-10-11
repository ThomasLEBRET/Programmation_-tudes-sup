def echange(T, i, j):
    T[i], T[j] = T[j], T[i]
    return T


def tri_selection(T):
    n = len(T)
    for i in range(0, n-2):
        indice_min = i
        for j in range(i+1, n-1):
            if T[j] < T[indice_min]:
                indice_min = j
        echange(T, i, indice_min)
    return T


def tri_bulle(T):
	n = len(T)
	for i in range(n):
		for j in range(0, n-i-1):
			if T[j+1] < T[j]:
				T = echange(T, j+1, j)
	return T


def comptage(T):
	Tc = [0]*(max(T) + 1)
	size = len(T)
	for i in range(0, size):
		Tc[T[i]] = Tc[T[i]] + 1
	return Tc


def tri_comptage(T):
	n = 0
	Tc = comptage(T)
	for i in range(0, max(T)+1):
		for j in range(0, Tc[i]):
			T[n] = i
			n = n + 1
	return T


def tri_transpo(T):
	trie = False
	while not(trie):
		trie = True
		for i in range(0, len(T), 2):
			if T[i] > T[i+1]:
				echange(T, i, i+1)
				trie = False
		for i in range(1, len(T) - 1, 2):
			if T[i] > T[i+1]:
				echange(T, i, i+1)
				trie = False

		for i in range(0, len(T) - 1):
			for j in range(1, len(T) - 1, 2):
				if T[i] > T[i+1]:
					echange(T, i, i+1)
			for k in range(0, len(T) - 1, 2):
				if T[k] > T[k+1]:
					echange(T, k, k+1)
	return T
