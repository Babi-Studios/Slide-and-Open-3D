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
        if (transform.position.y < initialYPos - 1.0) Destroy(gameObject);
    }
    // Update is called once per frame

}
