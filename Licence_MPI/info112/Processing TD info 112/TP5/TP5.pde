void setup(){
  size(500, 500);
}

void drawPoly(float x, float y, int R){
      background(255);
    float ANG = PI/3;

    // dessine une courbe point par point
    stroke(100, 255, 200);
    fill(200, 255, 200);
    beginShape();
    vertex(x +100*cos(0), y+100*sin(0));
    for (int i=1; i<7; i++) {
      float x0 = x +R*cos(i*ANG);
      float y0 = x+R*sin(i*ANG);
      float dx = -R/2*sin(i*ANG);
      float dy = R/2*cos(i*ANG);
      
      float x1 = x + 100*cos((i-1)*ANG);
      float y1 = x + 100*sin((i-1)*ANG);
      float xm = (x0+x1)/2;
      float ym = (y0+y1)/2;
      fill(0, 0, 255);
      ellipse(x1,y1, 10,10);
      fill(0, 255, 0);
      ellipse(xm,ym, 10,10);
      fill(255, 0, 0);
      bezierVertex(x0+dx, y0+dy, x0-dx, y0-dy, x0, y0);
    }
    fill(200, 255, 200);
   endShape(CLOSE);
}

void draw()  {
  float distance = (3)/2*2*100;
     translate(width/2,height/2);
  drawPoly(0,0,100);
  for(int i=1; i<7;i++) 
  {
  translate(0, distance);
  drawPoly(0,0,100);
    translate(0, -distance);
    rotate(-PI/3);
}
}
