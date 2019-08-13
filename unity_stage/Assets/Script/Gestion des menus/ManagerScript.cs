using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    //Variables

    public float score;
    public string timer;
    public bool premiereClef;
    
    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        this.timer = GameObject.Find("MainCamera").GetComponent<Timer>().timerText.text;
        //TODO - changer cette variable
        this.premiereClef = false;
    }

    // Update is called once per frame
    void Update()
    {
        this.score = GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        this.timer = GameObject.Find("MainCamera").GetComponent<Timer>().timerText.text;
        //TODO - changer cette variable
        this.premiereClef = false;
    }
}
