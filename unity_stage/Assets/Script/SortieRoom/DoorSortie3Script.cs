using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSortie3Script : MonoBehaviour
{
    
    //Variables
    private Animator anim;
    public bool coffreTrouve;
    
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
        //clef inactive au début
        
        this.coffreTrouve = GameObject.Find("SalleSortie/keySortie").GetComponent<GetKeyScript>().ClefOuverture;
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
