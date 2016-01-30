
// steganography

/////////////////////////////////////////// CHOP TO HIDE /////////////////////////////
function chop2hide(image, bits){
    for(var px of image.values()){
        px.setRed(Math.floor(px.getRed()/bits) * bits);
        px.setGreen(Math.floor(px.getGreen()/bits) * bits);
        px.setBlue(Math.floor(px.getBlue()/bits) * bits);
        //px.setGreen(pixchange(px.getGreen()));
        //px.setBlue(pixchange(px.getBlue()));
    }
    return image;
}


////////////////////////////// SHIFT /////////////////////////////////////////////
function shift(im, bits){
  var nim = new SimpleImage(im.getWidth(), 
                            im.getHeight());
  for(var px of im.values()){
    var x = px.getX();
    var y = px.getY();
    var npx = nim.getPixel(x,y);
    npx.setRed(Math.floor(px.getRed()/bits));
    npx.setGreen(Math.floor(px.getGreen()/bits));
    npx.setBlue(Math.floor(px.getBlue()/bits));
  }
  return nim;
}


////////////////////////////////////////    CROP   ///////////////////////////////////
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


///////////////////////////////// CHECK IF TOO BIG, PRINT ERROR MESSAGE  /////////////////////////
function newpv(p,q){
     var answer = p+q;
     if (p+q > 255)   print("error too big: answer");
     return answer;
}

///////////////////////////////////////    COMBINE     //////////////////////////////////////////
function combine(a,b){

	var n = new SimpleImage(a.getWidth(), a.getHeight());
    for(var pa of a.values()){
   
	var x = pa.getX();
	var y = pa.getY();
	var pb = b.getPixel(x,y);
	var np = n.getPixel(x,y);
	
	//newpv displays Error 
	np.setRed(newpv(pa.getRed(),pb.getRed()));
	np.setGreen(newpv(pa.getGreen(),pb.getGreen()));
	np.setBlue(newpv(pa.getBlue(),pb.getBlue()));
	
    }
    return n; 
}


////////////////////////////////////////    EXTRACT    //////////////////////

function chop2hideReverse(pic, bits){
    for(var px of pic.values()){
        px.setRed((px.getRed() - ( Math.floor(px.getRed()/bits) * bits)) * bits;);        
		px.setGreen((px.getGreen() - ( Math.floor(px.getGreen()/bits) * bits)) * bits;);
		px.setBlue((px.getBlue() - ( Math.floor(px.getBlue()/bits) * bits)) * bits;);
        //px.setGreen(pixchangeReverse(px.getGreen()));
        //px.setBlue(pixchangeReverse(px.getBlue()));
    }
    return pic;
}


function extract(pixel, bits) {
	var n = new SimpleImage(pixel.getWidth(), pixel.getHeight());
	
	var nChop = chop2hideReverse(pixel, bits);
	
	for(var pa of nChop.values()){
   
		var x = pa.getX();
		var y = pa.getY();
		var np = n.getPixel(x,y);
		np.setRed(pa.getRed());
		np.setGreen(pa.getGreen());
		np.setBlue(pa.getBlue());
	
    }
	return n;
}

///////////////////////////////////////////    TEST CODE ////////////////
var astra = new SimpleImage("astrachan.jpg");

var start = crop(astra, 200, 300);
var hide = new SimpleImage("duvall.jpg");

print(start);
print(hide);

start = chop2hide(start);
hide = shift(hide);

var combine = combine(start, hide);

print(combine);

var extract = extract(combine);

print(extract);


