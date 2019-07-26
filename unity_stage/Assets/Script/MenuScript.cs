using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Codage du bouton quitter
    public void Quitter ()
    {
        Application.Quit();
    }
    
    //Codage du bouton Jouer
    public void Jouer()
    {
        SceneManager.LoadScene(1);
    }
}
