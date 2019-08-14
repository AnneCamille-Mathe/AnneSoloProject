using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class SimpleSave : MonoBehaviour
{
    //Variables
    public  GameObject managerScript;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        ES2.Save(player.transform.position, "position");
        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        ES2.Save(script.score, "score");
        ES2.Save(script.minutes, "minutes");
        ES2.Save(script.secondes, "secondes");
        ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
    }

}
