using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageBubbleScript : MonoBehaviour
{
    
    //Variables
    public GameObject PanelText;
    
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
            PanelText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PanelText.SetActive(false);
    } 
}
