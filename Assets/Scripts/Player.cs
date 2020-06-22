using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Manhole [] manholes;
    // Start is called before the first frame update
    void Start()
    {
        manholes = FindObjectsOfType<Manhole>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    private void CheckInput()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Open();
        }
    }
    private void Open()
    {
        foreach(Manhole manhole in manholes)
        {
            manhole.SignalRotation();
        }
    }
}
