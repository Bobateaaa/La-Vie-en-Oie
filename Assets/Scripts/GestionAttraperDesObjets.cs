using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
    Gestion pour que le joueuer puisse attraper des objets
    https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

   Par : Matilda
   Dernière modification : 06/11/2024
*/

public class GestionAttraperDesObjets : MonoBehaviour
{
    public GameObject objetAAttraper; // objet à attraper
    public GameObject cibleJoueur; // le joueur dont l'oie qui prend l'objet
    public float vitesse; // vitesse à laquelle l'objet suit le joueur
    public Vector3 offset; // distance entre l'objet et le joueur
    public bool peuEtreAttraper; // si l'objet peut être attrapé du script GestionCollisions
    public bool bougeVersCible; //indique si l'objet doit bouger vers la cible
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(-2, 2, -2);
        peuEtreAttraper = false;
        bougeVersCible = false;

    }

    // Update is called once per frame
    void Update()
    {
     
        if (peuEtreAttraper == true && Input.GetKeyDown(KeyCode.P))
        {
            bougeVersCible = true;
            
        } else if (bougeVersCible == true && Input.GetKeyDown(KeyCode.X))
        {
            BougerVersCible();
            bougeVersCible = false;
            Invoke("ResetAttraper", 1f);
        }

        

        // Si l'objet peut être attrapé
        if (bougeVersCible == true)
        {
            BougerVersCible(); 
            peuEtreAttraper = false;
        }


    }

    void OnTriggerEnter(Collider triggerTrue)
    {
        // Si l'objet entre en collision avec le joueur
        if (triggerTrue.gameObject.name == "HitboxGoose")
        {
            peuEtreAttraper = true;
        }
    }

    void OnTriggerExit(Collider triggerFalse)
    {
        // Si l'objet n'est plus en collision avec le joueur
        if (triggerFalse.gameObject.name == "HitboxGoose")
        {
            peuEtreAttraper = false;
        }
    }


    void BougerVersCible()
    {
        if(bougeVersCible == true)
        {
        peuEtreAttraper = false;

        Vector3 positionCible = cibleJoueur.transform.position + offset;

        // L'objet suit le joueur
        objetAAttraper.transform.position = Vector3.MoveTowards(objetAAttraper.transform.position, positionCible, vitesse * Time.deltaTime);
        }	
    }

    void ResetAttraper()
    {
        peuEtreAttraper = false;
    }


}
