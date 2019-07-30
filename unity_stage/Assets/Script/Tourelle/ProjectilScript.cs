using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilScript : MonoBehaviour
{
    //Initialisation des variables
    private Vector3 spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        this.spawnPoint = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
           GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score -= 1;
           GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score_Info.text = "Score : " + GameObject.Find("SpawnFPSController/ZoneSpawn").GetComponent<LifeScript>().Score;
        }
    }
}
