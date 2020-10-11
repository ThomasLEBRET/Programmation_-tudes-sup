from database import *


def searchBooks(isbn, title, author):
	request = "SELECT * FROM books"
	param = []
	if isbn != "":
		request = "SELECT * FROM books WHERE isbn LIKE ?"
		param = isbn
	if title != "":
		request = "SELECT * FROM books WHERE title LIKE ?"
		param = title
	if author != "":
		request = "SELECT * FROM books WHERE author LIKE ?"
		param = author

	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, ('%'+param+'%', ))
	connexion.commit()
	books = cursor.fetchall()
	close(cursor)
	return books


def searchBookById(id):
	request = "SELECT * FROM books"
	param = []
	if id != "":
		request = "SELECT * FROM books WHERE id = ?"
		param.append(id)
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, (param))
	connexion.commit()
	book = cursor.fetchone()
	close(cursor)
	return book


def getAvisByIdBook(idbook):
	request = "SELECT u.nom, u.prenom, a.avis, a.note, u.id FROM user u, avis a, books b  WHERE b.id = a.id  AND a.iduser = u.id AND a.idBook = ?"
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, (idbook,))
	connexion.commit()
	book = cursor.fetchall()
	close(cursor)
	return book


def getAvisByUserFromBook(book):
	row = getAvisByIdBook(book)
	for i in range(len(row)):
		if session['id'] == row[i][4]:
			return True
	return False


def avgBookById(id):
	request = "SELECT AVG(a.note) FROM user u, avis a, books b  WHERE b.id = a.id  AND a.iduser = u.id AND a.idBook = ?"
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, (id,))
	connexion.commit()
	book = cursor.fetchone()[0]
	close(cursor)
	return book


def postAvis(idUser, idBook, avis, note):
	if note == "":
		note = 0
	if avis == "":
		avis = "Sans avis"
	params = [idUser, idBook, avis, note]
	request = "INSERT INTO avis(idUser, idBook, avis, note) VALUES (?,?,?,?)"
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, (idUser, idBook, avis, note))
	connexion.commit()
	close(cursor)
