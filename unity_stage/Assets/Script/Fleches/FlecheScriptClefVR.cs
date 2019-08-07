using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlecheScriptClefVR : MonoBehaviour
{
    //Variables
    public bool code_trouve;
    public GameObject flecheBubbleVR;
    
    // Start is called before the first frame update
    void Start()
    {
        this.code_trouve = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
    }

    // Update is called once per frame
    void Update()
    {
        this.code_trouve = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.flecheBubbleVR.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (code_trouve && other.gameObject.tag == "Player")
        {
           this.flecheBubbleVR.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.flecheBubbleVR.SetActive(false);
        }
    }
}
