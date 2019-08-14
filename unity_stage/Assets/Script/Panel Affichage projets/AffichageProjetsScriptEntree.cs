using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AffichageProjetsScriptEntree : MonoBehaviour
{
    
    //Variables
    public GameObject panelText;
    public GameObject conflit;
    
    
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
            StartCoroutine(this.Zone());
            panelText.SetActive(true);
            
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
