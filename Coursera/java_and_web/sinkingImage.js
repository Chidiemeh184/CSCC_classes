
//Modifying an Image
function ensureInImage(coordinate, size) {
	//coordinate cannot be negative
	if (coordinate < 0){
		return 0;
	}
	
	// coordinate must be in range [0..size-1]
	if (coordinate >= size){
		return size - 1;
	}
	
	return coordinate;
}

function getPixelNearby (image, x, y, diameter){
	var dx = Math.random() * diameter - diameter/2;
	var dy = Math.random() * diameter - diameter/2;
	var nx = ensureInImage(x + dx, image.getWidth());
	var ny = ensureInImage(y + dy, image.getHeight());
	return image.getPixel(nx, ny);
}



//Sinks the Image to the bottom of the pool sink in meters, colorchange with increasing blue
// colorChange is four times the sink level 
function inThePool(image, sink, colorChange){
	var output = new SimpleImage(image.getWidth(), image.getHeight());
	
	for (var pixel of image.values()){
		
		var x = pixel.getX();
		var y = pixel.getY();
		
		if(Math.random() > 0.5 ){
			var other = getPixelNearby(image, x, y, sink);
			output.setPixel(x, y, other);
		}
		
		else {
			output.setPixel(x, y, pixel);
		}
	}
	
	for (var p of output.values()) {
      
        var  redValue = p.getRed();
        var  blueValue = p.getBlue();
        var greenValue = p.getGreen();
        var newBlueValue = blueValue + colorChange;
    
         if (newBlueValue < 255){
             redValue = p.setBlue(newBlueValue);
        }
        else {
            p.setBlue(255);
        }
	}
	
	return output;
}

var first = new SimpleImage("duvall.jpg");
var drownImage = inThePool(first, 70, 320);
print("Before Sinking");
print(first);
print("After Sinking");
print(drownImage);
