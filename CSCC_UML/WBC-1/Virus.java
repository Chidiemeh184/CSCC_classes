import greenfoot.*;

/**
 * Write a description of class Virus here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Virus extends Actor
{
    /**
     * Act - adds virus andmove them to the left of screen
     */
    public void act() 
    {
        
        setLocation(getX()-2, getY());
        turn(1);
        
        if (getX() == 0) 
        {
            getWorld().removeObject(this);
        }
    }    
}
