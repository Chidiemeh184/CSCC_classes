//Crop

function crop(image, width, height) {
	
	var output = new SimpleImage(width, height);
	
	for(var pixel of image.values()) {			
	
		var x = pixel.getX();
		var y = pixel.getY();
			
		//colors
		var r = pixel.getRed();
		var b = pixel.getBlue();
		var g = pixel.getGreen();

		if(x < width && y < height) {
		    var op = output.getPixel(x, y);
			op.setRed(r);
			op.setBlue(b);
			op.setGreen(g);
		}
	}
	
	return output;
}


///// Testing Crop //////
var astra = new SimpleImage("astrachan.jpg");

var smallAstra = crop(astra, 200, 300);

print(astra);
print(astra.getWidth(), astra.getHeight());
print(smallAstra);





