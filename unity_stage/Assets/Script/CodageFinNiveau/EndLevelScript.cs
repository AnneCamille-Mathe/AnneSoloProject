using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour
{
    
    //Variables
    public string LevelToLoad;
    public GameObject PanelText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(this.LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        this.PanelText.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(this.LevelToLoad);
    }
}
