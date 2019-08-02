using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class Detectionprojet1 : MonoBehaviour
{
    //Variables
    public GameObject texte;
    
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
            texte.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        texte.SetActive(false);
    } 
}
