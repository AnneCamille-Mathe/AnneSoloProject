using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleche5Script : MonoBehaviour
{
    //Variables
    public GameObject fleche5;
    public bool code_trouve;
    
    // Start is called before the first frame update
    void Start()
    {
        this.code_trouve = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
    }

    // Update is called once per frame
    void Update()
    {
        this.code_trouve = GameObject.Find("Canvas_empiler/TextManager").GetComponent<CombinaisonScript>().trouve;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.code_trouve)
        {
            this.fleche5.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.fleche5.SetActive(false);
        }
    }
}
