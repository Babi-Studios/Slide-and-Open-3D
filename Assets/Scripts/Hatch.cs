using UnityEngine;

public class Hatch : MonoBehaviour
{
    public static bool AllHatchesAreClosed = true;

    public bool isPurpleHatch;

    bool isOpening = false;
    bool isClosing = false;
    float currentRotation = 0f;

    const float MAX_ANGLE= 86;
    const float DELAY = 0;
    const float OPENING_SPEED = 350f;
    const float CLOSING_SPEED = 120f;

    Vector3 target;
    Vector3 axis;

    private void Start()
    {
        target = transform.position;
        if(isPurpleHatch)
        {
            axis = Vector3.left;
            target.z += transform.localScale.y / 2;
        }
        else
        {
            axis = Vector3.right;
            target.z -= transform.localScale.y / 2;
        }
    }

    private void Update()
    {

        if(isOpening)
        {
            float delta = Time.deltaTime * OPENING_SPEED;
            if(currentRotation + delta > MAX_ANGLE)
            {
                delta = MAX_ANGLE - currentRotation;
            }
            currentRotation += delta;
            transform.RotateAround(target, axis, delta);
            if(currentRotation >= MAX_ANGLE)
            {
                currentRotation = 0f;
                isOpening = false;
                isClosing = true;
            }
        }
        if(isClosing)
        {
            float delta = Time.deltaTime * CLOSING_SPEED;
            if (currentRotation + delta > MAX_ANGLE)
            {
                delta = MAX_ANGLE - currentRotation;
            }
            currentRotation += delta;
            transform.RotateAround(target, axis * -1, delta);
            if (currentRotation >= MAX_ANGLE)
            {
                currentRotation = 0f;
                isClosing = false;
                AllHatchesAreClosed = true;
            }
        }
    }

    public void Open()
    {
        if(isClosing || !AllHatchesAreClosed)
        {
            return;
        }
        isOpening = true;
    }
}
