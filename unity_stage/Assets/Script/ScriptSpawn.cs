///////// Script Spawn Player pour Udemy //////////////////
///////////////////////////////////////////////////////////
////////  Instructeur Parein Jean-philippe ////////////////
///////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
   	void OnTriggerEnter (Collider Other)
    {
        Debug.Log("OnTriggerEnter");
        if(Other.gameObject.name== "RigidBodyFPSController")
        {
            //Other.gameObject.GetComponent<CharacterController>().enabled = false;
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
            //Other.gameObject.GetComponent<CharacterController>().enabled = true;

        }	
	}		
}
