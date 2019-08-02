using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClefVRScript : MonoBehaviour
{
    //Variables
    public bool GetKeyVR = false;
    public GameObject PanelText;
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetKeyVR = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetKeyVR = true;
            StartCoroutine(this.GetKey());
            GameObject.Find("BubbleVR/key").SetActive(false);
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score += 5;
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
            //TODO : voir pourquoi pas effacement
        }
    }
    
    IEnumerator GetKey()
    {
        print("OK REALISEE");
        yield return new WaitForSeconds(4f);
        PanelText.SetActive(false);
    }
}
