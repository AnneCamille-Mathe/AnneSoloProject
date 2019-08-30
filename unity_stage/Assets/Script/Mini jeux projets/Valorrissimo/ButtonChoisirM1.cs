using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChoisirM1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        bool colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        bool seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;

        if (famille && colloc && ! seul)
        {
            
        }

        
        
    }
}
