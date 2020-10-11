// fonction d'initialisation
void setup(){
  // tout en hauteur pour faire pousser les plantes !
  size(300, 600);
  noLoop();
}

// fonction de dessin principale
void draw() {
  // parametres de dessins initiaux
  background(64, 64, 255);
  stroke (0, 192, 64);
  strokeWeight(2);

  // on part du bas vers le haut
  drawRec(width/2, height, width/2, height-250);
  drawRec(width/3, height, width/3, height-250);

}
void drawRec(int x1, int y1, int x2, int y2) {
  // on arrete la recursivite au quand on coupe les cheveux en 4 !
  if (dist(x1,y1,x2,y2)<1) return;

  // Calcule de la prochaine etape
  // - on part du bout (x2, y2)
  // - on ajoute le vecteur des deux derniers points ... divise par 3
  // - on part sur le cote en ajoutant le vecteur orthogonal ... divise par 5
  int x3 = x2+ (x2-x1)/3 + (y2-y1)/5;
  int y3 = y2+ (y2-y1)/3 + (x1-x2)/5;

  // on dessine l"etape courante
  line(x1, y1, x2, y2);

  // on appelle  l"etape suivante
  drawRec(x2, y2, x3, y3);
}
