using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSortie3Script : MonoBehaviour
{
    
    //Variables
    private Animator anim;
    //TODO - MODIFIER CETTE VARIABLE !
    public bool coffreTrouve = false;
    
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
        if (this.coffreTrouve)
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
