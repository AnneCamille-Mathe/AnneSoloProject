using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    
    // Variables
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().LockedDoor)
        {
            this.anim.SetTrigger("OpenDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.anim.enabled = true;
        //GameObject.Find("Cube_Panda").GetComponent<MovePandaScript>().debut = true;
    }

    void pauseAnimationEvent()
    {
        this.anim.enabled = false;
    }
}
