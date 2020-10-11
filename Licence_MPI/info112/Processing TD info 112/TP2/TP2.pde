void setup() {
  background(0);
  size(900, 500);
  noLoop();
}

void draw(){
  int px = mouseX;
  int py = mouseY;
  stroke(255, 255, 255);
  strokeWeight(3);
  line(0, 0, px, py);
}

void mouseMoved() {
  int px = mouseX;
  int py = mouseY;
  loadPixels();
  pixels[px+py*width] = color(255, 255, 0);
  pixels[width*height-width*py+px] = color(255, 0, 255);
  println("la souris est "+px+", "+py);
  updatePixels();
  redraw();
}
