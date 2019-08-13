using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoad : MonoBehaviour
{
    //Variables
    public GameObject managerScript;
    public GameObject player;
   

    // Start is called before the first frame update
    
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public  void Load()
    {
        player.transform.position = ES2.Load<Vector3>("position");
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        
        //mise à jout du score
        script.score = ES2.Load<float>("score");
        GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score = ES2.Load<float>("score");
        GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text =
            "Score : " + ES2.Load<float>("score");
        
        //TODO - Mettre à jour (même chose que pour le score)
        script.timer = ES2.Load<string>("timer");
        script.premiereClef = ES2.Load<bool>("premiereClef");
        
    }
}
