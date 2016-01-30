// border frame using a function, refactored
function setBlack(pixel){
    pixel.setRed(0);
    pixel.setGreen(0);
    pixel.setBlue(0);
    return pixel;
}
/*function pixelOnEdge(pixel,image){
    var x = pixel.getX();
    var y = pixel.getY();
    if (x < 10) return true;
    if (y < 10) return true;
    if (x >= image.getWidth() - 10) return true;
    if (y >= image.getHeight() - 10) return true;
    return false;
}*/
function pixelOnVerticalEdge(pixel, image, borderWidth){
    var x = pixel.getX();
    var y = pixel.getY();
    if (x < borderWidth) return true;
    if (x >= image.getWidth() - borderWidth) return true;
    return false;
}
function pixelOnHorizontalEdge(pixel, image, borderWidth){
    var x = pixel.getX();
    var y = pixel.getY();
    if (y < borderWidth) return true;
    if (y >= image.getHeight() - borderWidth) return true;
    return false;
}

var image = new SimpleImage("lion.jpg");
for (var pixel of image.values()) {
   if (pixelOnVerticalEdge(pixel, image, 10)){
       pixel = setBlack(pixel);
   }
   if (pixelOnHorizontalEdge(pixel, image, 30)){
       pixel = setBlack(pixel);
   }
}
print(image);
