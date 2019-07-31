using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    //Variables
    public GameObject PanelText;
    public bool OnceEnter = false;
    
    // Start is called before the first frame update
    void Start()
    {
        PanelText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !this.OnceEnter)
        {
            PanelText.SetActive(true);
            StartCoroutine(this.DesactivationPanel());
            this.OnceEnter = true;
        }
    }
    
    IEnumerator DesactivationPanel()
    {
        yield return new  WaitForSeconds(8f);
        PanelText.SetActive(false);
    }
}
