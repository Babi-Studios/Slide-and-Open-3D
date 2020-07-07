using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBalls : MonoBehaviour
{
    private List<GameObject> balls = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        if (other.gameObject.GetComponent<AbstractBall>() != null)
            balls.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<AbstractBall>() != null)
            balls.Remove(gameObject);
    }
}
