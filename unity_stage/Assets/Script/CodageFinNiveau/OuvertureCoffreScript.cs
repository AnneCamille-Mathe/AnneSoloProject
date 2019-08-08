using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCoffreScript : MonoBehaviour
{
    // Variables
    Animator anim;
    public GameObject key;

    private int eviteBug = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        this.anim.SetTrigger("OuvrirCoffre");
        //Eviter l'erreur lorsque clef disparue
        if (this.eviteBug == 1)
        {
            StartCoroutine(this.WaitKey());
            this.eviteBug = 2;
        }
    }

    void PauseAnimationEvent()
    {
        this.anim.enabled = false;
    }

    IEnumerator WaitKey()
    {
        yield return new WaitForSeconds(1f);
        this.key.SetActive(true);
    }
}
