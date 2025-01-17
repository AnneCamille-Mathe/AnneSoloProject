﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveTrigger : MonoBehaviour
{
    //Variables
    public GameObject player;
    public GameObject boutonJouer;
    public GameObject ZoneSpawn;
    public GameObject MainCamera;
    public int marqueur = 1;
    public GameObject CanevasDebut;
    public GameObject CanevasChoix;
        

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

            if (ES2.Exists("Hermes"))
            {
                ES2.Delete("Hermes");
            }
            
            if (ES2.Exists("Valorissimo"))
            {
                ES2.Delete("Valorissimo");
            }

            if (ES2.Exists("SEngager"))
            {
                ES2.Delete("SEngager");
            }

            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");
        }
        else
        {
            this.CanevasDebut.SetActive(false);
            this.CanevasChoix.SetActive(false);
        }
        Load();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ES2.Exists("SEngager"))
            {
                this.boutonJouer.SetActive(true);
            }
            
            ES2.Save(player.transform.position, "position");
            ES2.Save(this.ZoneSpawn.GetComponent<LifeScript>().Score, "score");
            
            //TODO - Calcul du temps
            ES2.Save(this.MainCamera.GetComponent<Timer>().minutes, "minutes");
            ES2.Save(this.MainCamera.GetComponent<Timer>().secondes, "secondes");
            //float temps = ES2.Load<int>("minutes") + ES2.Load<int>("secondes");
            //ES2.Save(temps, "temps");
            
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            
            //Si pas début de jeu = pas de panel explicatif à afficher
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");

        }
    }
    
    public void Load()
    {    
        player.transform.position = ES2.Load<Vector3>("position");
        this.ZoneSpawn.GetComponent<LifeScript>().Score = ES2.Load<float>("score");
        //Calcul du temps
        this.MainCamera.GetComponent<Timer>().minutes = ES2.Load<int>("minutes");
        this.MainCamera.GetComponent<Timer>().secondes = ES2.Load<int>("secondes");
        //this.MainCamera.GetComponent<Timer>().temps = ES2.Load<int>("temps");
    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
