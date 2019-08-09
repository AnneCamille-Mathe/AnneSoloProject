using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageSortieScript : MonoBehaviour
{
    //Variables
    public GameObject panelText;
    public bool clefTrouve;
    //Panneau sortie
    public GameObject panneauSortie;
    
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
        //Variable clef trouvee
        this.clefTrouve = GameObject.Find("SalleSortie/keySortie").GetComponent<GetKeyScript>().ClefOuverture;
        
        //Si clef pas trouvée : message de base
        if (!this.clefTrouve)
        {
            StartCoroutine(this.AffichageMessageDefaite());
        }
        //Sinon message victoire
        else
        {
            StartCoroutine(this.AffichageMessageSuccess());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.panelText.SetActive(false);
    }

    //La clef a été trouvée
    IEnumerator AffichageMessageSuccess()
    {
        this.panelText.SetActive(true); 
        Destroy(this.panneauSortie);
        GameObject.Find("SalleSortie/CanvasSortie3e/PanelSortie3e/TextSortie3e").GetComponent<Text>().text = "Felicitations vous avez rempli la mission !";
        yield return new WaitForSeconds(0.5f);

    }
    
    //La clef n'a pas été trouvée
    IEnumerator AffichageMessageDefaite()
    {
        this.panelText.SetActive(true);
        yield return new WaitForSeconds(0.5f);
    }
}
