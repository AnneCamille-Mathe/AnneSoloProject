using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    //Variables
    public GameObject PanelText;
    public bool test;

    
    // Start is called before the first frame update
    void Start()
    {
        this.test =  GameObject.Find("Canvas_empiler/Panel_combinaison/TextManager")
            .GetComponent<CombinaisonScript>().trouve;
    }

    // Update is called once per frame
    void Update()
    {
        this.test =  GameObject.Find("Canvas_empiler/Panel_combinaison/TextManager")
            .GetComponent<CombinaisonScript>().trouve;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && (this.test == false))
        {
            PanelText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PanelText.SetActive(false);
    } 
}