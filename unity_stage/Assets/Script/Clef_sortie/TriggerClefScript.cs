using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerClefScript : MonoBehaviour
{
   
    //Variables
    //Bug affichage du message VR  : désactivation 
    //public GameObject PanelTextVRBug;
    
    // Start is called before the first frame update
    void Start()
    {
      //  this.PanelTextVRBug.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //this.PanelTextVRBug.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        //this.PanelTextVRBug.SetActive(false);

        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(this.GetKey());
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //this.PanelTextVRBug.SetActive(false);

        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().PanelText.SetActive(false);
    }

    IEnumerator GetKey()
    {
        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().LockedDoor = false;
        GameObject.Find("Canvas_Clef").GetComponent<ClefScript>().PanelText.SetActive(true);
        GameObject.Find("Canvas_Clef/Panel_Clef/Text_Clef").GetComponent<Text>().text = "Porte deverouillee";
        yield return new WaitForSeconds(0.5f);
    }

}

















