using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeVRDoor : MonoBehaviour
{
    //Variables
    private Animator anim;
    public GameObject PanelText;
    
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("BubbleVR/key") == null)
        {
           this.anim.SetTrigger("OpenDoor");
        }
        else
        {
            PanelText.SetActive(true);
            StartCoroutine(DesactivationPanel());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.anim.enabled = true;
    }

    void PauseAnimationEvent()
    {
        this.anim.enabled = false;
    }
    
    IEnumerator DesactivationPanel()
    {
        yield return new  WaitForSeconds(5f);
        PanelText.SetActive(false);
    }
}
