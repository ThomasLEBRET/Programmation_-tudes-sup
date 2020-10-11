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
  soleil (width/2, height/2, 80, 12);
}
