using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjetSEngager : MonoBehaviour
{
    //Variables
    public GameObject CanevasMission;
    public GameObject CanevasControl;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        StartCoroutine(this.desepear());
    }

    IEnumerator desepear()
    {
        GameObject.Find("Canvas_Mission/Panel_Mission/Text_Mission").GetComponent<Text>().text = "Votre mission : detruisez les clones de l'IA avec les armes de l'armee et accedez au site";
        GameObject.Find("Canvas_Mission/Panel_Mission/ButtonContinue/Text").GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        this.CanevasMission.SetActive(false);
        this.CanevasControl.SetActive(true);
    }
}
