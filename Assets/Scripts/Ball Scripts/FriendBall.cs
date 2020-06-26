using UnityEngine;

public class FriendBall : AbstractBall
{
    public void Awake()
    {
        isFriend = true;
    }

    public override void DestroyByFalling(Game game)
    {
        Debug.Log("O oo You let your friend fall down");
        game.DecreaseLives();
        Destroy(gameObject);
    }

    public override void DestroyByReachingBase(Game game)
    {
        Debug.Log("+10 Points");
        game.IncreasePoints();
        Destroy(gameObject);
    }
}