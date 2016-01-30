
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

function chop2hideReverse(px, bits){
    
        var ty = (px -  Math.floor(px/bits) * bits);        
		
		//px.setGreen((px.getGreen() - ( Math.floor(px.getGreen()/bits) * bits)) * bits);
		//px.setBlue((px.getBlue() - ( Math.floor(px.getBlue()/bits) * bits)) * bits);
        //px.setGreen(pixchangeReverse(px.getGreen()));
        //px.setBlue(pixchangeReverse(px.getBlue()));
    return ty;
}


function extract(pixel, bits) {
	//var n = new SimpleImage(pixel.getWidth(), pixel.getHeight());
	
	//var nChop = chop2hideReverse(pixel, bits);
	
	for(var pa of pixel.values()){
   
		//var x = pa.getX();
		//var y = pa.getY();
		//var np = n.getPixel(x,y);
		
		pa.setRed(chop2hideReverse(pa.getRed(), bits));
		pa.setGreen(chop2hideReverse(pa.getGreen(), bits));
		pa.setBlue(chop2hideReverse(pa.getBlue(), bits));
	
    }
	return pixel;
}


function pixchangeReverse(pixval, bits){
    var x = (pixval - ( Math.floor(pixval/bits) * bits)) * bits;
    return x;
}

function chop2hideReverse(pic, bit){
    for(var px of pic.values()){
        px.setRed(pixchangeReverse(px.getRed(), bit));
        px.setGreen(pixchangeReverse(px.getGreen(), bit));
        px.setBlue(pixchangeReverse(px.getBlue(), bit));
    }
    return pic;
}


function extract(pixel, bit) {
	var n = new SimpleImage(pixel.getWidth(), pixel.getHeight());
	
	var nChop = chop2hideReverse(pixel, bit);
	
	for(var pa of pixel.values()){
   
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

print("START === Before chopping Red at 30, 52");
var sp = start.getPixel(30, 52);
print(sp.getRed());

print("HIDE === Before shifting Red at 30, 52");
var sp = hide.getPixel(30, 52);
print(sp.getRed());


print(hide);

start = chop2hide(start, 4);
hide = shift(hide, 64);

print("START === After chopping Red at 30, 52");
var sp = start.getPixel(30, 52);
print(sp.getRed());

print("HIDE === After shifting Red at 30, 52");
var sp = hide.getPixel(30, 52);
print(sp.getRed());

var combine = combine(start, hide);
//var combine = new SimpleImage("gay2.png");

print(combine);
print("COMBINE ==== Red at 30, 52");
var sp = combine.getPixel(30, 52);
print(sp.getRed());

//var shifted = shift(combine, 64);
var extract = extract(combine, 4);

print(extract);

print("EXTRACT ==== Red at 30, 52");
var sp = extract.getPixel(30, 52);
print(sp.getRed());
















