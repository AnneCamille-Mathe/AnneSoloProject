using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClefScript : MonoBehaviour
{
    //Variables
    public GameObject PanelText;
    public bool LockedDoor = true;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DesactivationPanel());
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
