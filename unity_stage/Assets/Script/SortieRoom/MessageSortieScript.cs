using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSortieScript : MonoBehaviour
{
    //TODO - Modification victoire : voir TriggerClefScript Folder Clef_Sortie
    //Variables
    public GameObject panelText;
    
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
        this.panelText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        this.panelText.SetActive(false);
    }
}
