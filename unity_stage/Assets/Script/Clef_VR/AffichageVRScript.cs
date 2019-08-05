using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageVRScript : MonoBehaviour
{
    //Variables
    public GameObject PanelText;
    public bool test;
    
    // Start is called before the first frame update
    void Start()
    {
        this.test = GameObject.Find("BubbleVR/key") == null;
    }

    // Update is called once per frame
    void Update()
    {
        this.test = GameObject.Find("BubbleVR/key") == null;
    }

    private void OnTriggerEnter(Collider other)
    {
        print(GameObject.Find("BubbleVR/key")==null);
        if (other.gameObject.tag == "Player" && test)
        {
            this.PanelText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.PanelText.SetActive(false);
    }
}
