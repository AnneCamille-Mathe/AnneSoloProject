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
    
    // Start is called before the first frame update
    void Start()
    {
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
            this.boutonJouer.SetActive(true);
            ES2.Save(player.transform.position, "position");
            ManagerScript script = managerScript.GetComponent<ManagerScript>();
            ES2.Save(script.score, "score");
            ES2.Save(script.minutes, "minutes");
            ES2.Save(script.secondes, "secondes");
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");

        }
    }
    
    public void Load()
    {    
        player.transform.position = ES2.Load<Vector3>("position");    
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        script.score = ES2.Load<float>("score");
        script.minutes = ES2.Load<int>("minutes");
        script.secondes = ES2.Load<int>("secondes");

    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
