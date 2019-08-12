using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class AffichageProjetsScriptEntree : MonoBehaviour
{
    
    //Variables
    public GameObject panelText;
    public GameObject conflit;
    
    //Freezer
    private FreezerScript Freezer;
    public GameObject mgr;
    
    // Start is called before the first frame update
    void Start()
    {
       //ajout
       //GameObject mgr = GameObject.FindWithTag("Manager");
       if (mgr)
       {
           Freezer = mgr.GetComponent<FreezerScript>();
       }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(this.Zone());
            panelText.SetActive(true);
            
            //ajout
            Freezer.Freeze();
            

            if (conflit != null)
            {
                conflit.SetActive(false);
            }
        }
    }

    IEnumerator Zone()
    {
        yield return new WaitForSeconds(2f);
        panelText.SetActive(false);
    }
}
