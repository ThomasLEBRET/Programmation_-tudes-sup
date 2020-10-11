from flask import Flask, render_template, session
import sqlite3 as sql


def connect():
	connexion = sql.connect("projectone.db")
	return connexion


def close(connexion):
	return connexion.close()


def closeSession():
	session.clear()
