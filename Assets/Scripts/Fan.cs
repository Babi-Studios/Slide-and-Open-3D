using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float strength;
    private Vector3 force;

    private bool isRotating;
    private List<GameObject> ballsToPush = new List<GameObject>();

    private void Update()
    {
        force = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up) * new Vector3(strength, 0, 0);
        if (Input.GetKeyDown(KeyCode.W) && !isRotating)
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
            ballsToPush.RemoveAll(ball => ball == null);
            foreach (GameObject ball in ballsToPush)
            {
                ball.GetComponent<Rigidbody>().AddForce(force);
            }
        }
    }

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
}
