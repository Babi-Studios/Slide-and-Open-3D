using UnityEngine;

public class JokerBall : AbstractBall
{
    public void Awake()
    {
        isJoker = true;
    }

    public override void DestroyByFalling(Game game)
    {
        //nothing?
        Destroy(gameObject);
    }

    public override void DestroyByReachingBase(Game game)
    {
        Debug.Log("+20 Points with Joker");
        game.IncreasePoints();
        game.IncreasePoints();
        Destroy(gameObject);
    }
}