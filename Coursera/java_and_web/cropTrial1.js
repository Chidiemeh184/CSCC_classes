// show image
var image = new SimpleImage("vine.jpg");
print(image);


function crop(image, width, height){
    var nim = new SimpleImage(width, height);
    
    for(var p of image.values(); p < image.getWidth(); p++){
        var imR = p.getRed();
        var imG = p.getGreen();
        var imB  = p.getBlue();
    }
    for (var pix of nim.values()){
        pix.setRed(imR);
        pix.setGreen(imG);
        pix.setBlue(imB);
    }
    
    return nim;
}

var image2 = crop(image, 225, 225);
print(image2);


//Crop Revised
function crop(image, width, height){
  var n = new SimpleImage(width,height);
     for(var p of image.values()){
   	   var x = p.getX();
   	   var y = p.getY();
  	  
  	  if (x < width && y < height){
        var np = n.getPixel(x,y);
        np.setRed(p.getRed());
        np.setBlue(p.getBlue());
        np.setGreen(p.getGreen()); 
        }
     }
     return n;
}
//Crop Full Code
var start = new SimpleImage("girl.jpg");
var hide = new SimpleImage("climb.jpg");

var cropWidth = start.getWidth();
if (hide.getWidth() < cropWidth) {
	cropWidth = hide.getWidth();
}
var cropHeight = start.getHeight();
if (hide.getHeight() < cropHeight) {
	cropHeight = hide.getHeight();
}

function crop(image, width, height){
  var n = new SimpleImage(width,height);
     for(var p of image.values()){
   	   var x = p.getX();
   	   var y = p.getY();
  	  
  	  if (x < width && y < height){
        var np = n.getPixel(x,y);
        np.setRed(p.getRed());
        np.setBlue(p.getBlue());
        np.setGreen(p.getGreen()); 
        }
     }
     return n;
}


start = crop(start, cropWidth, cropHeight);
hide = crop(hide,cropWidth, cropHeight);
print(start);
print(hide);