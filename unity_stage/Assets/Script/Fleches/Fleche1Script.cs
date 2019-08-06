using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleche1Script : MonoBehaviour
{
    //Variables
    public bool code_trouve;
    public GameObject fleche1;
    
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
        if (!code_trouve && other.gameObject.tag == "Player")
        {
            this.fleche1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.code_trouve)
        {
            this.fleche1.SetActive(false);
        }
    }
}
