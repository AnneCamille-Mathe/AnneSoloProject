using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePandaScript : MonoBehaviour
{
    //Variables
    private RaycastHit Hit;
    public bool debut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (debut)
        {
            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, 2))
            {
                transform.Rotate(Vector3.up * Random.Range(150, 200));
                Debug.Log(Hit.collider.name);
            }
        }
    }
}
