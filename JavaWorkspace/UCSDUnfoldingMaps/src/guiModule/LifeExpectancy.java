package guiModule;

import de.fhpotsdam.unfolding.UnfoldingMap;
import de.fhpotsdam.unfolding.providers.Google;
import de.fhpotsdam.unfolding.utils.MapUtils;

public class LifeExpectancy extends PApplet {
	UnfoldingMap map;
	
	public void setup()
	{
		//Sets up size of canvas
		size(800, 600, OPENGL);
		
		//
		map = new UnfoldingMap(this, 50, 50, 700, 500, new Google.GoogleMapProvider());
		MapUtils.createDefaultEventDispatcher(this, map);
	}
	
	public void draw()
	{
		map.draw();
	}
}
