using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlecheScriptPorteMur : MonoBehaviour
{
    //Variables
    public GameObject flechePorteMur;
    private int compt = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //L'utilisateur ne doit passer qu'une fois dans le trigger
    
 
    private void OnTriggerEnter(Collider other)
    {
        if (this.compt ==0 && GameObject.Find("BubbleVR/key") == null && other.gameObject.tag == "Player")
        {
            this.flechePorteMur.SetActive(true);
            this.compt = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.flechePorteMur.SetActive(false);
        }
    }
}
