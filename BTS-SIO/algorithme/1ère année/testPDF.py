from reportlab.pdfgen import canvas
from reportlab.lib.units import cm

pdf = canvas.Canvas('commande.pdf')
titre = input("Nom de la commande")
num = input("Numéro de commande")
date = input("Date de commande")
details = input("Détails de la commande")

pdf.drawString(3*cm, 25*cm, (titre))
pdf.drawString(3*cm, 3*cm, (num))
pdf.drawString(3*cm, 50*cm, (date))
pdf.line(3*cm,24.5*cm,18*cm,24.5*cm)
pdf.drawString(3*cm, 23*cm, (details))

pdf.save()
