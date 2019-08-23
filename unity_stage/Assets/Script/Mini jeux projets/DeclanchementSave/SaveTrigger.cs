﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveTrigger : MonoBehaviour
{
    //Variables
    public  GameObject managerScript;
    public GameObject player;
    public GameObject boutonJouer;
    public bool debutDeJeu = true;
    public GameObject CanevasDebut;
    public GameObject ZoneSpawn;
    public GameObject MainCamera;
    public int marqueur = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (ES2.Load<bool>("jeuLance") == true & ES2.Load<int>("marqueur") == 1)
        {
            if (ES2.Exists("position"))
            {
                ES2.Delete("position");
            }
            
            if (ES2.Exists("minutes"))
            {
                ES2.Delete("minutes");
            }

            if (ES2.Exists("savedScene"))
            {
                ES2.Delete("savedScene");
            }
            
            if (ES2.Exists("score"))
            {
                ES2.Delete("score");
            }
            
            if (ES2.Exists("secondes"))
            {
                ES2.Delete("secondes");
            }
            
        }
        else
        {
            this.CanevasDebut.SetActive(false);
        }
        
        Load();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ES2.Load<int>("marqueur"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.boutonJouer.SetActive(true);
            ES2.Save(player.transform.position, "position");
            ManagerScript script = managerScript.GetComponent<ManagerScript>();
            ES2.Save(this.ZoneSpawn.GetComponent<LifeScript>().Score, "score");
            ES2.Save(this.MainCamera.GetComponent<Timer>().minutes, "minutes");
            ES2.Save(this.MainCamera.GetComponent<Timer>().secondes, "secondes");
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            
            //Si pas début de jeu = pas de panel explicatif à afficher !
            this.debutDeJeu = false;
            ES2.Save(this.debutDeJeu, "debutDeJeu");
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");

        }
    }
    
    public void Load()
    {    
        player.transform.position = ES2.Load<Vector3>("position");
        this.ZoneSpawn.GetComponent<LifeScript>().Score = ES2.Load<float>("score");
        this.MainCamera.GetComponent<Timer>().minutes = ES2.Load<int>("minutes");
        this.MainCamera.GetComponent<Timer>().secondes = ES2.Load<int>("secondes");
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        
        //Si pas début de jeu = pas de panel explicatif à afficher !
        this.debutDeJeu = ES2.Load<bool>("debutDeJeu");
    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
