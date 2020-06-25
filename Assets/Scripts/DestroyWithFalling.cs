using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithFalling : MonoBehaviour
{
    float initialYPos;
    // Start is called before the first frame update
    void Start()
    {
        initialYPos = transform.position.y;
    }

    private void Update()
    {
        if (gameObject.tag == "Enemy"||gameObject.tag=="Joker"||gameObject.tag=="Heart")
        {
            if (transform.position.y < initialYPos - 1.0) Destroy(gameObject);
        }
        if (gameObject.tag == "Friend")
        {
            if (transform.position.y < initialYPos - 1.0)
            {
                FindObjectOfType<LevelDesigner>().HeartDecreaser();
                Destroy(gameObject);
                Debug.Log("O oo You let your friend fall down");
                return;
            }
            
        }
    }
    // Update is called once per frame

}
