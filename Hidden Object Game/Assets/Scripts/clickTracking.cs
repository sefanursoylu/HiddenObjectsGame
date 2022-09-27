using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickTracking : MonoBehaviour
{
    public static int totalClicks = 0;
    public KeyCode mouseClick;
    public int penaltyClicks;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(mouseClick))
        {
            totalClicks += 1;
        }

        if (totalClicks >= penaltyClicks)
        {
            Debug.Log("MINUS 10 SECONDS");
        }

        Debug.Log(totalClicks);
    }
}
