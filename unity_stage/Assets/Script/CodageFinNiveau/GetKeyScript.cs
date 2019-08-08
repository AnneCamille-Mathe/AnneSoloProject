using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyScript : MonoBehaviour
{
    //Variables
    public GameObject key;
    public GameObject panelText;
    //sinon incrémentation du score trop rapide
    private int count = 0;
    //On regarde si la clef a été prise
    public bool ClefOuverture = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //sinon incrémentation du score à chaque entrée
            if (this.count == 0)
            {
                GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score += 10;
                GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
                this.ClefOuverture = true;
            }

            this.count += 1;
            this.key.SetActive(false);
            this.panelText.SetActive(true);
            StartCoroutine(this.WaitPanel());
        }
    }

    //On attend avant de désactiver le panel
    IEnumerator WaitPanel()
    {
        yield return new WaitForSeconds(3f);
        this.panelText.SetActive(false);
    }
}
