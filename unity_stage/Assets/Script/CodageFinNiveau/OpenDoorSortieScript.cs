using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSortieScript : MonoBehaviour
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
        if (other.gameObject.tag == "Player")
        {
            this.anim.SetTrigger("OpenDoor");
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        this.anim.enabled = true;
    }

    void PauseAnimationEvent()
    {
        this.anim.enabled = false;
    }
}
