void setup(){
  size(300, 300);
}

void draw(){
  loadPixels();
  colorMode(HSB, 255); // ou dans le setup()
  for (int j = 0; j < height; j++) {
    for (int i = 0; i < width; i++) {
      float dc = dist(i, j, width/2, height/2);
      float dc3 = dist(i, j, -width/6, height/6);
      if (dc<=height/2 && dc3>260){
        float h = 0;
        float s = 0;  
        float dbordint = (dc3-260);
        float dbordext = -(dc-height/2);
        float b = (dbordint*255 +dbordext*90)/(dbordint+dbordext);
        pixels[j*width+i] = color(h, s, b);
      }
    }
  }
  updatePixels();
}
