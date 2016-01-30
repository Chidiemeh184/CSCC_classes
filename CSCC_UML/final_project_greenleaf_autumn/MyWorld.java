import greenfoot.*;

/**
 * Autumn. A world with some leaves.
 * 
 * @author Michael Kölling
 * @version 0.1
 */
public class MyWorld extends World
{
    /**
     * Create the world and objects in it.
     */
    public MyWorld()
    {    
        super(600, 400, 1);
        setUp();
    }
    
    /**
     * Create the initial objects in the world.
     */
    private void setUp()
    {
        addObject(new Block(), 300, 200);
        int i = 0;
        
        while(i < 18)
        {
            addObject(new Leaf(), Greenfoot.getRandomNumber(500), Greenfoot.getRandomNumber(700));
            i++;
        }
    }
}
