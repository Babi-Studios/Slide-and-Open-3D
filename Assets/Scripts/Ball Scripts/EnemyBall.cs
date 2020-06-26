using UnityEngine;

public class EnemyBall : AbstractBall
{
    public void Awake()
    {
        isEnemy = true;
    }

    public override void DestroyByFalling(Game game)
    {
        //increment score?
        Destroy(gameObject);
    }

    public override void DestroyByReachingBase(Game game)
    {
        Debug.Log("Bye Bye");
        game.DecreaseLives();
        Destroy(gameObject);
    }
}