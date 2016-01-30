import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * This is a white blood cell. This kind of cell has the job to catch 
 * bacteria and remove them from the blood.
 * 
 * @author Michael Kölling
 * @version 0.1
 */
public class WhiteCell extends Actor
{
   
    /**
     * Act: move up and down when cursor keys are pressed.
     */
    public void act() 
    {
        checkKeyPress();
        checkCollision();
    }
    
    /**
     * Check whether a keyboard key has been pressed and react if it has.
     */
    private void checkKeyPress()
    {
        if (Greenfoot.isKeyDown("up")) 
        {
            setLocation(getX(), getY()-4);
        }
        
        if (Greenfoot.isKeyDown("down")) 
        {
            setLocation(getX(), getY()+4);
        }
        
        if (Greenfoot.isKeyDown("left")) 
        {
            setLocation(getX()-4, getY());
        }
        
        if (Greenfoot.isKeyDown("right")) 
        {
            setLocation(getX()+4, getY());
        }
    }
    
    /**
     * Checks if touching the virus and removes the WBC(ends the game)
     */
    
    private void checkCollision()
    { 
        if(isTouching(Bacteria.class))
    {
        removeTouching(Bacteria.class);
        Greenfoot.playSound("slurp.wav");
        Bloodstream bloodstream = (Bloodstream)getWorld();
        bloodstream.addScore(20);
      
    }
     if(isTouching(Virus.class))
    {
        removeTouching(Virus.class);
        Bloodstream bloodstream = (Bloodstream)getWorld();
        bloodstream.addScore(-100);
      
    }
    }
}
