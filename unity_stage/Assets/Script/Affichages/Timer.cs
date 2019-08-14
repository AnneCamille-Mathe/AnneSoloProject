
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Déclaration de variables
    private float temps = 400;
    public Text timerText;
    public int minutes;
    public int secondes;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (this.temps >= 0)
        {
            this.minutes = Mathf.FloorToInt(this.temps / 60f);
            this.secondes = Mathf.RoundToInt(this.temps % 59f);
            this.temps -= Time.deltaTime;
            if (this.secondes < 10)
            {
                this.timerText.text = (this.minutes + ":0" + this.secondes);  
            }

            else if (this.minutes < 10)
            {
                this.timerText.text = ("0" + this.minutes + ":" + this.secondes);  
            }
            else if (this.minutes < 10 && this.secondes < 10)
            {
                this.timerText.text = ("0" + this.minutes + ":0" + this.secondes);  
            }
            else
            {
                this.timerText.text = (this.minutes + ":" + this.secondes);
            }
            
        }
        else
        {
            this.timerText.text = ("TIME OVER");
            SceneManager.LoadScene("GameOver");
        }
        
        
  
        
        


    }
}
