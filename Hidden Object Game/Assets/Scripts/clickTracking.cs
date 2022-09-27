using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickTracking : MonoBehaviour
{
    public static int totalClicks = 0;
    public KeyCode mouseClick;
    public int penaltyClicks;

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
            Debug.Log("MINUS 10 SECONDS");
            //timerScript.time -= 10 * Time.deltaTime;
            //timerScript.time -= Time.deltaTime;
        }

        Debug.Log(totalClicks);
    }
}
