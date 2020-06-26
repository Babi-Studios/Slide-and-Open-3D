using UnityEngine;

public class FallingDetector : MonoBehaviour
{
    public Game game;

    private void OnCollisionEnter(Collision collision)
    {
        AbstractBall ball = collision.gameObject.GetComponent<AbstractBall>();
        if (ball != null)
        {
            ball.DestroyByFalling(game);
        }
    }
}
