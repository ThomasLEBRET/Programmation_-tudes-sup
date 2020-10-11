PImage img;

void setup() {
  size(640, 440);
  img = loadImage("logo.png");
  img.resize(img.width, img.height);
  img.loadPixels();
    for (int j=0; j < img.height/2; j=j+1) {
    for (int i=0; i < img.width/2; i=i+1) {
      img.pixels[i+j*img.width] = color(i,i+j,j);
    }
  }
  img.updatePixels();
  noLoop();
}

void draw() {
  image(img, (width-img.width)/2, (height-img.height)/2);
}
