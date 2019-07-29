using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    //Variables
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bool locked = GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().LockedDoor;
            if (!locked)
            {
                GameObject.Find("Classic_Door_01").transform.Rotate(Vector3.negativeInfinity, 160*Time.deltaTime);
            }
        }
    }
}
