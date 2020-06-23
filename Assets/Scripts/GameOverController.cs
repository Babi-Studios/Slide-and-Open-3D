using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Bye Bye");
            FindObjectOfType<LevelDesigner>().HeartDecreaser();
            collision.transform.position = new Vector3(-100, -100, 100);
        }
        if (collision.gameObject.tag == "Heart")
        {
            Debug.Log("+1 Heart");
            FindObjectOfType<LevelDesigner>().HeartIncreaser();
            collision.transform.position = new Vector3(-100, -100, 100);
        }
        if (collision.gameObject.tag == "Friend")
        {
            Debug.Log("+10 Points");
            FindObjectOfType<LevelDesigner>().PointsIncreaser();
            collision.transform.position = new Vector3(-100, -100, 100);
        }
        if (collision.gameObject.tag == "Joker")
        {
            Debug.Log("+20 Points with Joker");
            FindObjectOfType<LevelDesigner>().PointsIncreaser();
            FindObjectOfType<LevelDesigner>().PointsIncreaser();
            collision.transform.position = new Vector3(-100, -100, 100);
        }
    }
}
