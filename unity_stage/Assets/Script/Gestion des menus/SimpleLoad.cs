using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoad : MonoBehaviour
{
    //Variables
    public GameObject managerScript;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Load()
    {
        player.transform.position = ES2.Load<Vector3>("position");
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        script.score = ES2.Load<int>("score");
        script.timer = ES2.Load<float>("timer");
        script.premiereClef = ES2.Load<bool>("premiereClef");
        
    }
}
