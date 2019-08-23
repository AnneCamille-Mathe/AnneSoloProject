using System;
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
    public int test;
    public GameObject CanevasScore;
    
    // Start is called before the first frame update
    void Start()
    {
        Load();
        this.CanevasDebut.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.boutonJouer.SetActive(true);
            ES2.Save(player.transform.position, "position");
            ManagerScript script = managerScript.GetComponent<ManagerScript>();
            ES2.Save(this.CanevasScore.GetComponent<LifeScript>().Score, "score");
            ES2.Save(script.minutes, "minutes");
            ES2.Save(script.secondes, "secondes");
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            ES2.Save(test, "test");
        }
    }
    
    public void Load()
    {    
        player.transform.position = ES2.Load<Vector3>("position");
        this.CanevasScore.GetComponent<LifeScript>().Score = ES2.Load<float>("score");
        CanevasScore.GetComponent<LifeScript>().Score_Info.text  = "Score : " + this.CanevasDebut.GetComponent<LifeScript>().Score;
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        script.minutes = ES2.Load<int>("minutes");
        script.secondes = ES2.Load<int>("secondes");
    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
