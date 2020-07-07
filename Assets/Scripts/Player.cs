using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] lanes;
    public int startingLaneIndex;

    private int currentLaneIndex;
    private List<Hatch> hatches;

    private bool isChangingLanes;

    void Start()
    {
        currentLaneIndex = lanes.Length / 2;
        ChangeLane(lanes[currentLaneIndex]);
    }

    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if(!isChangingLanes)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                currentLaneIndex--;
                if (currentLaneIndex < 0) currentLaneIndex = 0;
                ChangeLane(lanes[currentLaneIndex]);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                currentLaneIndex++;
                if (currentLaneIndex > lanes.Length - 1) currentLaneIndex = lanes.Length - 1;
                ChangeLane(lanes[currentLaneIndex]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OpenHatches();
        }
    }

    private void ChangeLane(GameObject lane)
    {
        isChangingLanes = true;
        LeanTween.moveX(gameObject, lane.transform.position.x, 0.3f)
            .setEaseOutExpo()
            .setOnComplete(() => {
                isChangingLanes = false;
            });
        foreach (Transform child in lane.transform)
        {
            if (child.tag == "Hatches")
            {
                hatches = new List<Hatch>();
                foreach(Transform hatch in child.transform)
                {
                    hatches.Add(hatch.GetChild(0).GetComponent<Hatch>());
                    hatches.Add(hatch.GetChild(1).GetComponent<Hatch>());
                }
                break;
            }
        }
    }

    private void OpenHatches()
    {
        foreach(Hatch hatch in hatches)
        {
            hatch.Open();
        }
        Hatch.AllHatchesAreClosed = false;
    }
}
