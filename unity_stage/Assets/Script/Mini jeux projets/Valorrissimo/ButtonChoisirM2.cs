using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChoisirM2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        bool colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        bool famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;

        if (seul && colloc && famille)
        {
            
        }



    }
}
