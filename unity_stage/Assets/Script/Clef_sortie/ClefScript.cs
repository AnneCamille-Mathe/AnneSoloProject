using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClefScript : MonoBehaviour
{
    //Variables
    public GameObject PanelText;
    public bool LockedDoor = true;
    public GameObject CanevasDebut;
    
    // Start is called before the first frame update
    void Start()
    {
        if (ES2.Load<bool>("jeuLance") == true & ES2.Load<int>("marqueur") == 1 && this.CanevasDebut == null)
        {
            PanelText.SetActive(true);
            StartCoroutine(DesactivationPanel());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DesactivationPanel()
    {
        yield return new  WaitForSeconds(5f);
        PanelText.SetActive(false);
    }
}
