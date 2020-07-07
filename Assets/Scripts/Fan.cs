using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public Vector3 force;
    private bool isRotating;
    private List<GameObject> ballsToPush = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AbstractBall>() != null)
        {
            ballsToPush.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<AbstractBall>() != null)
        {
            ballsToPush.Remove(gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && !isRotating)
        {
            isRotating = true;
            LeanTween.rotateAround(gameObject, Vector3.right, 360f, 1f)
                .setEaseInOutQuad()
                .setOnComplete(() => {
                    isRotating = false;
                });
        }
        if(isRotating)
        {
            ballsToPush.ForEach((ball) =>
            {
                ball.GetComponent<Rigidbody>().AddForce(force);
            });
        }
    }
}
