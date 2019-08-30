using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoisirM1 : MonoBehaviour
{
    //Variables
    public GameObject persoFamille;
    public GameObject PanelFamille;
    public GameObject Button;
    public GameObject PanelMaison1;
    
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
        if (colloc && famille && !seul)
        {
            Button.SetActive(false);   
            persoFamille.SetActive(true);
            PanelFamille.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text = "C'est parfait, ma famille et moi allons être très bien ici, merci beaucoup !";
            PanelMaison1.SetActive(false);
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
