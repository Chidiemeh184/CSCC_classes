import greenfoot.*;  // (World, Actor, GreenfootImage, and Greenfoot)

/**
 * A piano that can be played with the computer keyboard.
 * 
 * @author: M. Kölling
 * @version: 0.1
 */
public class Piano extends World
{
    private String[] whiteKeys = {"a", "s", "d", "f", "g", "h", "j", "k", 
        "l", ";", "\\"};
    
    private String[] whiteNotes = 
      {"2c", "2d", "2e", "2f", "2g", "2a", "2b", "3c", "3d", "3e", "3f", "3g"};
    /**
     * Make the piano.
     */
    public Piano() 
    {
        super(800, 340, 1);
        makeKey();
    }
    
    public void makeKey()
    {   
        addObject(new Key("e", "4d#.wav", "black-key.png", "black-key-down.png"), 300, 140);
        addObject(new Key("r", "4c#.wav", "black-key.png", "black-key-down.png"), 104, 140);
        int i = 0;
        while(i < whiteKeys.length)
    {
        Key key = new Key(whiteKeys[i], whiteNotes[i] + ".wav", "white-key.png", "white-key-down.png");
        addObject (key, 54 + (i*63), 140);
        i= i + 1;     
    }
    }
}