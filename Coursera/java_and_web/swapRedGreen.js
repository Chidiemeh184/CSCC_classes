///////////////////// Swaps the green and red colour ////////////////
var testImage = new SimpleImage("mario.png");
/*for (var p of testImage.values()) {
    p.setRed(2);
    p.setGreen(250);
    p.setBlue(0);
}*/
print("Image before swap");
print(testImage);

function swapRedGreen(pixel){
    var redValue = pixel.getRed();
    var greenValue = pixel.getGreen();
    var blueValue = pixel.getBlue();
    
    if( (redValue > 240 ) && (redValue > (greenValue + blueValue)) ){
        pixel.setRed(greenValue);
        pixel.setGreen(redValue);
    }
    
    else if ((greenValue > 240) && (greenValue > (blueValue + redValue))) {
        pixel.setGreen(redValue);
        pixel.setRed(greenValue);
    }
    return pixel;
}



for (var pixel of testImage.values()) {
   pixel = swapRedGreen(pixel);
}


print("image after swap");
print(testImage);


///////////////////// Increase Red Pixels in an Image /////////////////
// Set Image size and colour 
var testImage = new SimpleImage(100, 100);
for (var p of testImage.values()) {
    p.setRed(100);
    p.setGreen(100);
    p.setBlue(0);
}
print("Before Adding Red");
print(testImage);

function moreRed(pixel, num){
  
  for (var p of pixel.values()) {
      
        var  redValue = p.getRed();
        var  blueValue = p.getBlue();
        var greenValue = p.getGreen();
        var newRedValue = redValue + num;
    
         if (newRedValue < 255){
             redValue = p.setRed(newRedValue);
        }
        else {
            p.setRed(255);
         }
  }
   
   return pixel;
   
}
//change red colour of second image
testImage2 = moreRed(testImage, 1);

print("After Adding Red");
print(testImage2);