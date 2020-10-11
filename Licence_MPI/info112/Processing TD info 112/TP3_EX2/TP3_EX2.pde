 void setup() {
    size(1080, 720);
    smooth();
    strokeWeight(1);
  }
  void draw() { 
      float b=random(0,255);
    background(0, 0, 128);
    stroke(255, 255, b, 255);
    for (int i=0; i<200; i++) {
        float r=random(200, 450);
    line(width/2, height/2, width/2+cos(i)*r, height/2+sin(i)*r);
      
loadPixels();
  for (int j = height/2-200; j < height/2+200; j++) {
    for (int k = width/2-200; k < width/2+200; k++) {
      float dc = dist(k, j, width/2, height/2);
      if (dc<=200)
        pixels[j*width+k] = color(255, 255, 255-dc, 255);
    }
  }
  updatePixels();
    }
  }
  
  
  
  
