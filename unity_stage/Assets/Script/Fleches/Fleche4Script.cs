using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleche4Script : MonoBehaviour
{
    //Variables
    public bool code_trouve;
    public GameObject fleche4;
    
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
            Debug.Log("PUTAIN DE MERDE");
            this.fleche4.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
            this.fleche4.SetActive(false);
        }
    }
}
