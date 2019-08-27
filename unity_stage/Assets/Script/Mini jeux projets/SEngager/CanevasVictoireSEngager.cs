using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanevasVictoireSEngager : MonoBehaviour
{
    //Variables
    public GameObject ImageScript;
    public GameObject ImageSite;

    public GameObject TexteVictoire;
    public bool once = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (once)
        {
            StartCoroutine(affichage());
            once = false;
        }
    }

    IEnumerator affichage()
    {
        yield return new WaitForSeconds(0.5f);
        ImageScript.SetActive(false);
        ImageSite.SetActive(true);
        yield return new  WaitForSeconds(1f);
        ImageSite.SetActive(false);
        TexteVictoire.SetActive(true);
        yield return  new WaitForSeconds(1f);
    }
}
