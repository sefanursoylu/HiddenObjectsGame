using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBehaviour : MonoBehaviour
{
    public static string nameofobj;
    public GameObject objnametext;
    public Transform successClick;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseUp()
    {
        nameofobj = gameObject.name;
        Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
        clickTracking.totalClicks = 0;

        Instantiate(successClick, transform.position, transform.rotation);
    }
}
