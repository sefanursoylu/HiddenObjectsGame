using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float time;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        {
            if (time <= 0.0f)
            {
                Debug.Log("YOU LOSE!");
                SceneManager.LoadScene("SefaScene");
            }
        }
    }
}
