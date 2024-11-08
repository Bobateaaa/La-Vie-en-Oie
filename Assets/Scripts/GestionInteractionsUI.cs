using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
   Gestion avec objet et ui pour attraper un objet et le faire tomber

   Par : Matilda
   Dernière modification : 04/11/2024
*/

public class GestionInteractionsUI : MonoBehaviour
{
    public GameObject objetAAttraper; // objet à attraper
    public bool peuAttraper; // si l'objet peut être attrapé
    public bool bougeVersCible; //indique si l'objet bouge vers la cible
    public GameObject UIActiver; // ui/bouton pour attraper l'objet
    public GameObject UIDesactiver; // ui/bouton pour faire tomber l'objet
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
        bougeVersCible = scriptAttraperObjet.bougeVersCible;
        
        // Si l'objet peut être attrapé
        if (peuAttraper == true)
        {
            UIActiver.SetActive(true);
        }
        else
        {
            UIActiver.SetActive(false);
        }

        if (peuAttraper == false && bougeVersCible == true)
        {
            UIDesactiver.SetActive(true);
        }
        else
        {
            UIDesactiver.SetActive(false);
        }

        
    }
}
