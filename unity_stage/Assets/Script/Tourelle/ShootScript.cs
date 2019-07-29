using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    //initialisation des variables
    public GameObject prefabProjectil;
    private GameObject projectil;
    public float shootRate = 2f;
    private float nextShoot;
    public int speed = 1000;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextShoot)
        {
            this.nextShoot = Time.time + this.shootRate; 
            this.projectil = Instantiate(this.prefabProjectil, transform.position, Quaternion.identity) as GameObject;
            this.projectil.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.right * this.speed));
            Destroy(this.projectil, 2f);
            

        }
    }
}
