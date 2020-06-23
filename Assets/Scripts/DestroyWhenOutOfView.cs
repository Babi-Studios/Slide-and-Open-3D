using UnityEngine;

public class DestroyWhenOutOfView : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
