using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CombinaisonScript : MonoBehaviour
{
    //Variables
    public InputField test;
    public bool trouve = false;
    public Text Text_succeed;
    
    // Start is called before the first frame update
    void Start()
    {
        this.trouve = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Text_changed()
    {
        if (test.text=="123")
        {
            Debug.Log("test reussite");
            this.trouve = true;
            GameObject.Find("Canvas_empiler/Panel_combinaison/Text_choix").SetActive(false);
            GameObject.Find("Canvas_empiler/Panel_combinaison/Text_succeed").SetActive(true);
            this.Text_succeed.text = "Bravo vous avez reussi !";
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score += 3;
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;

            
        }
        else if (test.text != "123")
        {
            Debug.Log("test fail");
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score -= 3;
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
            
            //5.72 1.39 -15.29
            //TODO enlever code du carré et l'expliquer rapport
        }
    }
    
   
}
