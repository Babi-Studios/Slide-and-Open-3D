using System;
using UnityEngine;
using UnityEngine.UI;

public class NumericalTextHandler : MonoBehaviour
{
    public string defaultText;

    private Text t;
    private int numeric;

    void Start()
    {
        t = GetComponent<Text>();
    }

    public int Get()
    {
        return numeric;
    }

    public void Set(int n)
    {
        numeric = n;
        t.text = defaultText + " " + numeric;
    }

    public void IncrementBy(int delta)
    {
        numeric += delta;
        t.text = defaultText + " " + numeric;
    }

    public void DecrementBy(int delta)
    {
        numeric -= delta;
        t.text = defaultText + " " + numeric;
    }
}
