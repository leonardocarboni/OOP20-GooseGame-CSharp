using System;
using static System.Net.Mime.MediaTypeNames;

public static class Info
{
    /**
     * Max shot on the game.
     */
    public static readonly int MAX_SHOT = 20;
    /**
     * Frame of the Timeline.
     */
    public static readonly int FRAME = 30;
    /**
     * Width of the screen.
     */
    public static readonly int WIDTH = 600;
    /**
     * Height of the screen.
     */
    public static readonly int HEIGHT = 480;
    /**
     * Size of the player.
     */
    public static readonly int SIZE_PLAYER = 60;
    /**
     * Size of the enemy. 
     */
    public static readonly int SIZE_ENEMY = 60;
    /**
     * Size of the shot.
     */
    public static readonly int SIZE_SHOT = 10;
    /**
     * These are used for the animation of the explosion.
     */
    public static readonly int EXPLOSION_IMG_NUM = 15;
    /**
     * Explosion widht of the image.
     */
    public static readonly int EXPLOSION_WIDTH = 128;
    /**
     * Explosion height of the image.
     */
    public static readonly int EXPLOSION_HEIGHT = 128;
    /**
     * Score of the game.
     */
    private static int score = 0;
    /**
     * True if the game is over.
     */
    private static bool isOver = false;

    /**
     * Used for check the distance.
     * 
     * @param x1 Position X of element 1.
     * @param y1 Position Y of element 1.
     * @param x2 Position X of element 2.
     * @param y2 Position Y of element 2.
     * @return the distance.
     */
    public static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }

    public static int GetScore()
    {
        return score;
    }

    public static void SetScore(int score)
    {
        Info.score = score;
    }

    public static bool IsOver()
    {
        return isOver;
    }

    public static void SetOver(bool isOver)
    {
        Info.isOver = isOver;
    }
}
