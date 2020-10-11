from database import *


def userExist(email, password):
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute("SELECT * FROM user WHERE email = ? AND password = ?", (email, password))
	connexion.commit()
	if cursor.fetchone():
		return True
	return False


def signinUser(user):
	if userExist(user[2], user[3]):
		return False
	for row in session:
		if not(session[row]):
			return False
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute("INSERT INTO user(email, nom, prenom, password) VALUES (?,?,?,?)", (session["email"], session["nom"], session["prenom"], session["password"]))
	connexion.commit()
	session["nom"] = user[0]
	session["prenom"] = user[1]
	session["email"] = user[2]
	session["password"] = user[3]
	close(cursor)
	return True


def loginUser(email, password):
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute("SELECT * FROM user WHERE email = ? AND password = ?", (email, password))
	connexion.commit()
	user = cursor.fetchone()
	if user is None:
		return False
	session["id"] = user[0]
	session["email"] = user[1]
	session["nom"] = user[2]
	session["prenom"] = user[3]
	session["password"] = user[4]
	close(cursor)
	return True


def getUserById(iduser):
	request = "SELECT nom, prenom FROM user WHERE id = ?"
	connexion = connect()
	cursor = connexion.cursor()
	cursor.execute(request, (iduser))
	connexion.commit()
	user = cursor.fetchone()
	close(cursor)
	return user
