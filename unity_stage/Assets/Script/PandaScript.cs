using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Détection de l'objet
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Panda")
        {
            print("Trigger");
        }
    }
    
    //Détection sortie de l'objet
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Panda")
        {
            print("Exit trigger");
        }
    }
}
