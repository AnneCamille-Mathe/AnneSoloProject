using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoisirM2 : MonoBehaviour
{
    //Variables
    public GameObject persoSeul;
    public GameObject PanelSeul;
    public GameObject Button;
    public GameObject PanelMaison2;
    
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
        seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourFamille;
    }
    
    public void onClic()
    {
        if (colloc && famille && seul)
        {
            Button.SetActive(false);   
            persoSeul.SetActive(true);
            PanelSeul.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text = "C'est parfait, je vais me plaire ici, merci beaucoup !";
            PanelMaison2.SetActive(false);
        }
        
        //TODO - Faire le cas ou colloc && !famille && !seul : afficher perso correspondant + message pas content
        if (colloc && !famille && !seul)
        {
            
        }
        
        //TODO - Faire le cas oy colloc && famille && seul : afficher perso correspondant + message pas content
        if (colloc && famille && seul)
        {
            
        }
    }
}
