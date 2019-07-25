using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class LifeScript : MonoBehaviour
{
    //Variables
    public float Score = 0;
    public Text Score_Info;

    // Start is called before the first frame update
    void Start()
    {
        this.Score_Info.text = "Score : " + this.Score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.Score -= 1;
            this.Score_Info.text = "Score : " + this.Score;

        }
    }
}