using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float force;
    public Vector3 forceToApply;

    private bool isRotating;
    private List<GameObject> ballsToPush = new List<GameObject>();

    private void Update()
    {
        forceToApply = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up) * new Vector3(force, 0, 0);
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
                ball.GetComponent<Rigidbody>().AddForce(forceToApply);
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
