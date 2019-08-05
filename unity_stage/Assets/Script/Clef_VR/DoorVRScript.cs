using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorVRScript : MonoBehaviour
{
    //Variables
    private Animator anim;
    public bool trouve_test;
    
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        this.trouve_test = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
    }

    // Update is called once per frame
    void Update()
    {
        this.trouve_test = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.trouve_test)
        {
            this.anim.SetTrigger("OpenDoor"); 
        }
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
