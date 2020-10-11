import csv
import sqlite3 as sql
from database import *

connexion = connect()
cursor = connexion.cursor()

with open('books.csv', newline='') as csvfile:
	reader = csv.DictReader(csvfile)
	for row in reader:
		isbn = row['isbn']
		title = row['title']
		author = row['author']
		year = row['year']
		cursor.execute("INSERT INTO books(isbn,title,author,year) VALUES(?,?,?,?)", (isbn, title, author, year))
		connexion.commit()
close(cursor)
