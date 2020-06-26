using UnityEngine;

public class BaseCollisionDetector : MonoBehaviour
{
    public Game game;

    private void OnCollisionEnter(Collision collision)
    {
        AbstractBall ball = collision.gameObject.GetComponent<AbstractBall>();
        if(ball != null)
        {
            ball.DestroyByReachingBase(game);
        }
    }
}
