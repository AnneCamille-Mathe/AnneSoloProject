using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleche3Script : MonoBehaviour
{
    //Variables
    public bool code_trouve;
    public GameObject fleche3;
    
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
        if (code_trouve && other.gameObject.tag == "Player")
        {
            this.fleche3.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.fleche3.SetActive(false);
        }
    }
}
