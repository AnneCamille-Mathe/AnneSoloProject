using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class DestroyOnTouchHermes : MonoBehaviour
{
    //variables
    public Camera camera;

    public GameObject horse1;
    /*
    public GameObject horse2;
    public GameObject horse3;
    */
    // Start is called before the first frame update
    void Start()
    {
    }


     void Update()
    {
        
        var mousePos = Input.GetTouch(0);
        //mousePos.z = 6;
        //Debug.Log(camera.ScreenToWorldPoint(mousePos));
        
        
        
        if (camera.ScreenToWorldPoint(mousePos.position).x > 0 && camera.ScreenToWorldPoint(mousePos.position).y > 0)
        {
            Destroy(horse1);
        }
        
        /*
        if (camera.ScreenToWorldPoint(mousePos).x > 2 && camera.ScreenToWorldPoint(mousePos).x < 5 && camera.ScreenToWorldPoint(mousePos).y > 1 && camera.ScreenToWorldPoint(mousePos).y < 3)
        {
            Destroy(horse2);
        }
        
        if (camera.ScreenToWorldPoint(mousePos).x > -1 && camera.ScreenToWorldPoint(mousePos).x < 1 && camera.ScreenToWorldPoint(mousePos).y > 0 && camera.ScreenToWorldPoint(mousePos).y < -1)
        {
            Destroy(horse3);
        } 
        */
    }
     
}
