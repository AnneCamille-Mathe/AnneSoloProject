﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageHermesScript : MonoBehaviour
{
    //Variables
    public GameObject panelText;
    
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
            this.panelText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.panelText.SetActive(false);
    }
}
