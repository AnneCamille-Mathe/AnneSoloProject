﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : MonoBehaviour
{
    //Variables
    public MeshRenderer textMesh;
    public float SecToFall = 2;
    public GameObject go_panda;
    public GameObject go_goblin_text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.go_panda = GameObject.Find("Cube_Panda");
        this.go_goblin_text = GameObject.Find("popup_goblin");
        if (go_panda==null)
        {
            StartCoroutine(TimeAffiche());
            this.textMesh.enabled = true;
            this.go_goblin_text.GetComponent<TextMesh>().text = "Merci beaucoup !";
      }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.textMesh.enabled = true;
            StartCoroutine(TimeAffiche());
        }
        else
        {
            this.textMesh.enabled = false;
        }
    }

    IEnumerator TimeAffiche()
    {
        yield return new WaitForSeconds(SecToFall);
        this.textMesh.enabled = false;
    }
}
