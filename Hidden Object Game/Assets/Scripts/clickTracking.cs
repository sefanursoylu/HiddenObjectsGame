using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickTracking : MonoBehaviour
{
    public static int totalClicks = 0;
    public KeyCode mouseClick;
    public int penaltyClicks;
    public int penaltyTime;

    private timer timerScript;

    void Start()
    {
        timerScript = GetComponent<timer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(mouseClick))
        {
            totalClicks += 1;
        }

        if (totalClicks >= penaltyClicks)
        {
            totalClicks = 0;
            Debug.Log("MINUS 10 SECONDS");
            timerScript.time -= penaltyTime;
        }

        Debug.Log(totalClicks);
    }
}
