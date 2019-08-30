using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoisirM3 : MonoBehaviour
{
    //Variables
    public GameObject persoColloc;
    public GameObject PanelCollocation;
    public GameObject Button;
    public GameObject PanelMaison3;
    
    private bool colloc;
    private bool famille;
    private bool seul;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        
    }

    public void onClic()
    {
        if (colloc && !famille && !seul)
        {
            Button.SetActive(false);   
            persoColloc.SetActive(true);
            PanelCollocation.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text = "C'est parfait, merci beaucoup !";
            PanelMaison3.SetActive(false);
        }
    }
}
