void setup(){
  size(640, 480);
}

void losange(float xa, float ya, float xb, float yb) {

  float ABx = xb-xa;
  float ABy = yb-ya;
  float xc = xa + ABx/2 + ABy;
  float yc = ya + ABy/2 - ABx;
  float xd = xa + ABx/2 - ABy;
  float yd = ya + ABy/2 + ABx;
  
  line(xa, ya, xb, yb);
  line(xa, ya, xc, yc);
  line(xa, ya, xd, yd);
  line(xb, yb, xc, yc);
  line(xb, yb, xd, yd);
}

void soleil(int xO, int yO, int R, int n){
  for (int i=0; i<n; i++){
    float a1 = 2*PI*i/n;
    float a2 = 2*PI*(i+1)/n;
    float x1 = R*cos(a1)+xO;
    float x2 = R*cos(a2)+xO;
    float y1 = R*sin(a1)+yO;
    float y2 = R*sin(a2)+yO;

    losange(x1,y1,x2,y2);
    fill(255,255,0);
    triangle(xO, yO, x1, y1, x2, y2);
  }
}
void draw(){
  gradientCiel(320, 240, 75, 255, 255, 255);

}


void gradientCiel(int xO, int yO, int R, int r, int g, int b) {
  loadPixels();
  for(int j=0; j<height; j++){
    for (int i=0; i<width; i++){
      int r0= ((255/2)*(height-j) + r*(j) )/(height-j + j);
      int g0= ((255/2)*(height-j) + g*(j) )/(height-j + j);
      int b0= ((255  )*(height-j) + b*(j) )/(height-j + j);
      float d = sqrt( (i-xO)*(i-xO)+(j-yO)*(j-yO));
      if (d>R && d<2*R){
        r0 = int (( (d-R)*r0 + (2*R-d) * 255 ) / R);
        g0 = int ( ((d-R)*g0 + (2*R-d) * 255 ) / R);
        b0 = int (( (d-R)*b0 + (2*R-d) * 255*3/4 ) / R);
      }
      pixels[i+j*width] = color(r0, g0, b0);
    }
  }
  updatePixels();
}
