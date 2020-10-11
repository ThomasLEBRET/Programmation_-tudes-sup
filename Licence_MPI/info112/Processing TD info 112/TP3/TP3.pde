PImage img;

void setup() {
  size(640, 440);
  img = loadImage("logo.png");
  img.resize(img.width, img.height);
  img.loadPixels();
  for (int j=0; j < img.height; j=j+1) {
    for (int i=0; i < img.width; i=i+1) {  
      int c = img.pixels[i+j*img.width];
      int a = (c&0xff000000)>>24;if (a<0) a+=256;
      int r = (c&0x00ff0000)>>16;if (r<0) r+=256;
      int g = (c&0x0000ff00)>>8;if (g<0) g+=256;
      int b = (c&0x000000ff)>>0;if (b<0) b+=256;
      img.pixels[i+j*img.width] = (a<<24) + (g<<16) + (b<<8) + (r<<0);
    }
  }
  img.updatePixels();
  noLoop();
} 
void draw() {
  image(img, (width-img.width)/2, (height-img.height)/2);
}
