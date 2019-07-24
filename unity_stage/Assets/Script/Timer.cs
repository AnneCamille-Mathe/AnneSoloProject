
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Déclaration de variables
    private float temps = 130;
    public Text timerText;
    private int minutes;
    private int secondes;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (this.temps >= 0)
        {
            this.temps -= Time.deltaTime;
        }
        else
        {
            this.timerText.text = ("TIME OVER");
        }
        
        this.minutes = Mathf.FloorToInt(this.temps / 60f);
        this.secondes = Mathf.RoundToInt(this.temps % 59f);
        this.timerText.text = (this.minutes + ":" + this.secondes);
  
        
        


    }
}
