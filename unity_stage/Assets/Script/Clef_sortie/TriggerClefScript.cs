using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerClefScript : MonoBehaviour
{
   
    
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
            StartCoroutine(this.GetKey());
            gameObject.SetActive(false);
            StartCoroutine(WaitBug());
            
        }
    }

    IEnumerator GetKey()
    {
        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().LockedDoor = false;
        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().PanelText.SetActive(true);
        GameObject.Find("Canvas_Clef/Panel_Clef/Text_Clef").GetComponent<Text>().text = "Porte deverouillee";
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator WaitBug()
    {
        yield return new WaitForSeconds(5f);
        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().PanelText.SetActive(false);
    }
}

















