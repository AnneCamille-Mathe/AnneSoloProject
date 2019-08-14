using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public  float score;
    public int minutes;
    public int secondes;
    
    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        this.minutes = GameObject.Find("Main Camera").GetComponent<Timer>().minutes;
        this.secondes = GameObject.Find("Main Camera").GetComponent<Timer>().secondes;
    }

    // Update is called once per frame
    void Update()
    {
        this.score = GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        this.minutes = GameObject.Find("Main Camera").GetComponent<Timer>().minutes;
        this.secondes = GameObject.Find("Main Camera").GetComponent<Timer>().secondes;
    }
}
