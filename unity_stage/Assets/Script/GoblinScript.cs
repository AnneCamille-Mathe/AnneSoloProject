using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : MonoBehaviour
{
    //Variables
    public MeshRenderer textMesh;
    public float SecToFall = 2;

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
