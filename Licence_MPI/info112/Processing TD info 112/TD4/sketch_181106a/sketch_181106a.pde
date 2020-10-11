void setup(){
  colorMode(HSB, 255);
  size(300, 300);
}

int N=32;
int R=100;
void draw(){
  for (int R=0; R<width/2; R+=10){
    strokeWeight(1+log(R+1)/log(10));
    for (int i=0; i<N; i++){
      float x0 = width/2 +R     *cos(i    *2*PI/N);
      float y0 = height/2+R     *sin(i    *2*PI/N);
      float x1 = width/2 +(R+10)*cos((i+1)*2*PI/N);
      float y1 = height/2+(R+10)*sin((i+1)*2*PI/N);
      stroke(i*255/N, R*255/(width/2), 255);
      line(x0, y0, x1, y1);
    }
  }
}
