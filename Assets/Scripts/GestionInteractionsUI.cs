using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionInteractionsUI : MonoBehaviour
{
    public GameObject objetAAttraper; // objet à attraper
    public bool peuAttraper; // si l'objet peut être attrapé
    public GameObject UIActiver; // bouton pour attraper l'objet
    private GestionAttraperDesObjets scriptAttraperObjet; // script pour attraper des objets
    // Start is called before the first frame update
    void Start()
    {
        scriptAttraperObjet = objetAAttraper.GetComponent<GestionAttraperDesObjets>();
        
    }

    // Update is called once per frame
    void Update()
    {
        peuAttraper = scriptAttraperObjet.peuEtreAttraper;
        // Si l'objet peut être attrapé
        if (peuAttraper == true)
        {
            UIActiver.SetActive(true);
        }
        else
        {
            UIActiver.SetActive(false);
            
        }

        
    }
}
