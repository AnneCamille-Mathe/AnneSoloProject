using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorVRScript : MonoBehaviour
{
    //Variables
    private Animator anim;
    
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
        this.anim.SetTrigger("OpenDoor");
    }

    private void OnTriggerExit(Collider other)
    {
        this.anim.enabled = true;
    }

    void pauseAnimationEvent()
    {
        this.anim.enabled = false;
    }
}
