using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CombinaisonScript : MonoBehaviour
{
    //Variables
    public InputField test;
    public Text Text_succeed;
    public bool trouve;
    
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
            GameObject.Find("Canvas_empiler/Panel_combinaison/Text_choix").SetActive(false);
            GameObject.Find("Canvas_empiler/Panel_combinaison/Text_succeed").SetActive(true);
            this.Text_succeed.text = "Bubble VR deverouillee";
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score += 3;
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
            this.trouve = true;
        }
        else if (test.text != "123")
        {
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score -= 3;
            GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        }
    }
    
   
}
