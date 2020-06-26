using UnityEngine;

public abstract class AbstractBall : MonoBehaviour
{
    public static Game game;

    public bool isFriend;
    public bool isEnemy;
    public bool isHeart;
    public bool isJoker;

    public float moveSpeed;

    private Rigidbody rb;

    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Update()
    {
        rb.AddForce(Vector3.back * moveSpeed, ForceMode.Acceleration);
    }

    public abstract void DestroyByFalling(Game game);
    public abstract void DestroyByReachingBase(Game game);
}