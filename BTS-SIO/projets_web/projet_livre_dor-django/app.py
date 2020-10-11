from flask import *
import sqlite3 as sql
import csv

#Dependences
from database import *
from user import *
from books import *


app = Flask(__name__)
app.secret_key = "session"


@app.route("/")
@app.route("/public/")
def index():
	title = "Accueil"
	return render_template('/index.html', title=title)


@app.route("/login/")
def login():
	if session:
		return redirect(url_for('/public/', title="Accueil"))
	else:
		return render_template('/connexion.html', title="Connexion")


@app.route("/singin/")
def singin():
	if session:
		return redirect(url_for('public', title="Accueil"))
	else:
		return render_template('/inscription.html', title="Inscription")


@app.route("/singin/add/", methods=["POST"])
def addUser():
	if session:
		return redirect(url_for('index'))
	if request.method == "POST":
		user = [request.form['nom'], request.form['prenom'], request.form['email'], request.form['password']]
		if signinUser(user):
			loginUser(user[2], user[3])
			return redirect(url_for('index'))
	return redirect(url_for('singin'))


@app.route("/login/connect/", methods=["POST"])
def logUser():
	if session:
		return redirect(url_for('index'))
	if request.method == "POST":
		email = request.form['email']
		password = request.form['password']
		if loginUser(email, password):
			return redirect(url_for('search'))
	return redirect(url_for('login'))


@app.route("/user/logout/")
def logout():
	session.clear()
	return redirect(url_for('index'))


@app.route("/user/search/")
def search():
	if session:
		return render_template('/search.html', title="Chercher un livre")
	else:
		return redirect(url_for('index'))


@app.route("/user/result/", methods=["GET", "POST"])
def result():
	if not(session):
		return redirect(url_for('index'))
	if request.method == "POST":
		isbn = request.form['isbn']
		title = request.form['title']
		author = request.form['author']
		books = []
		books = searchBooks(isbn, title, author)
		return render_template('/result.html', title="Résultat", books=books)
	else:
		return redirect(url_for('searchBook'))


@app.route("/user/result/<id>")
def books(id):
	book = searchBookById(id)
	avis = getAvisByIdBook(id)
	monavis = getAvisByUserFromBook(id)
	nbAvis = len(avis)
	n = len(avis)
	moyenne = 0
	if n > 0:
		moyenne = avgBookById(id)
	return render_template('/book.html', nbAvis=nbAvis, id=id, book=book, avis=avis, n=n, monavis=monavis, moyenne=moyenne, title="Avis")


@app.route("/user/result/<id>/post", methods=["POST"])
def avis(id):
	if session:
		return redirect(url_for('index'))
	if request.method == "POST":
		idUser = session["id"]
		idBook = id
		avis = request.form["avis"]
		note = request.form["note"]
		postAvis(idUser, idBook, avis, note)
	return redirect(url_for('books', id=id))


if __name__ == '__main__':
    app.run('0.0.0.0', port=8080, debug=True)
