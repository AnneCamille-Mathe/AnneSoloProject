using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerValorissimoScript : MonoBehaviour
{
    //Variables
    private int count = 1;
    
    public bool tourCooloc;
    public bool tourFamille;
    public bool tourSeul;
    
    public GameObject persoColoc;
    public GameObject persoFamille;
    public GameObject persoSeul;

    public GameObject PanelColoc;
    public GameObject PanelFamille;
    public GameObject PanelSeul;

    public GameObject CanevasDebut;
    
    // Start is called before the first frame update
    void Start()
    {
        tourCooloc = false;
        tourFamille = false;
        tourSeul = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanevasDebut.activeSelf == false & count == 1)
        {
            persoColoc.SetActive(true);
            PanelColoc.SetActive(true);
            count += 1;
        }

        if (persoColoc.activeSelf == true)
        {
            tourCooloc = true;
        }
        
        if (persoFamille.activeSelf == true)
        {
            tourFamille = true;
        }
        
        if (persoSeul.activeSelf == true)
        {
            tourSeul = true;
        }
        
    }
}
