using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
    Gestion du déplacement du personnage
    https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

   Par : Matilda
   Dernière modification : 01/11/2024
*/

public class GestionAttraperDesObjets : MonoBehaviour
{
    public GameObject objetAAttraper; // objet à attraper
    public GameObject cibleJoueur; // le joueur dont l'oie qui prend l'objet
    public float vitesse; // vitesse à laquelle l'objet suit le joueur
    public Vector3 offset; // distance entre l'objet et le joueur
    public bool peuEtreAttraper; // si l'objet peut être attrapé du script GestionCollisions
    private bool bougeVersCible; //indique si l'objet doit bouger vers la cible
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
            Invoke("ResetPeuAttraper", 2f);
            
        }


        // Si l'objet peut être attrapé
        if (bougeVersCible == true)
        {
            BougerVersCible();
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
        Vector3 positionCible = cibleJoueur.transform.position + offset;

        // L'objet suit le joueur
        objetAAttraper.transform.position = Vector3.MoveTowards(objetAAttraper.transform.position, positionCible, vitesse * Time.deltaTime);
    }

    void ResetPeuAttraper()
    {
        peuEtreAttraper = false;
    }


}
