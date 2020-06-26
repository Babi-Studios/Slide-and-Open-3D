using UnityEngine;

public class HeartBall : AbstractBall
{
    public void Awake()
    {
        isHeart = true;
    }

    public override void DestroyByFalling(Game game)
    {
        Destroy(gameObject);
    }

    public override void DestroyByReachingBase(Game game)
    {
        Debug.Log("+1 Heart");
        game.IncreaseLives();
        Destroy(gameObject);
    }
}