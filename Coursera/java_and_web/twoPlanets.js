var image = new SimpleImage(256, 256);

//Create a circle
 function dist(pixel, x,y) {
     var dx = pixel.getX() - x;
     var dy = pixel.getY() - y;
     return Math.sqrt(dx * dx + dy *dy);
 }


 for (var pixel of image.values()) {
	
	//Fading of Sun Rays
	var x = pixel.getX();
 	pixel.setRed(x - 40);
	pixel.setGreen(x - 109);
 	//pixel.setBlue(x);
 	
 	//Red planet
 	if (dist(pixel, 130, 120) < 18){
        pixel.setRed(240-4* dist(pixel,150, 110));
    }
    
    //Green Planet    
    else if (dist(pixel, 50, 120) < 25){
        pixel.setBlue(255- 4 * dist(pixel, 100, 100));
        pixel.setGreen(244- 3 * dist(pixel, 100, 100));
    }
    
    //Background stars
    else if (Math.random() >  0.9995) {
        pixel.setRed(250);
        pixel.setGreen(252);
    }
 
 }
 print(image);