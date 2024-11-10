using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
    Gestion pour que le joueuer puisse attraper des objets

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
    public Rigidbody rb; // rigidbody de l'objet à attraper
    public GameObject objetAcloner; // objet à cloner
    public Transform positionObjet; // position de l'objet à cloner
    public Animator anim; // animation
    public bool peutVerserEssence; // si on peut verser de l'essence
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = objetAAttraper.GetComponent<Rigidbody>();
        offset = new Vector3(-2, 2, -2);
        peuEtreAttraper = false;
        bougeVersCible = false;
        peutVerserEssence = true;

    }

    // Update is called once per frame
    void Update()
    {
     
        if (peuEtreAttraper == true && Input.GetKeyDown(KeyCode.P))
        {
            bougeVersCible = true;
            rb.isKinematic = true;
            
        } else if (bougeVersCible == true && Input.GetKeyDown(KeyCode.X))
        {
            BougerVersCible();
            bougeVersCible = false;
            rb.isKinematic = false;
            peuEtreAttraper = false;
        } else if (bougeVersCible == true && Input.GetKeyDown(KeyCode.Q))
        {
            if (peutVerserEssence == true)
            {
                anim.SetBool("estVerser", true);
                Invoke("VerserEssence", 1.5f);
                Invoke("DesactiverVerserEssence", 1f);

                peutVerserEssence = false;

                Invoke("ReactiverEssence", 2f);
            }
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

        // Fonction pour verser de l'essence 
    void VerserEssence()
    {
        GameObject cloneObjet = Instantiate(objetAcloner);
        cloneObjet.SetActive(true);
        cloneObjet.transform.position = positionObjet.position;

    }

    void DesactiverVerserEssence()
    {
        anim.SetBool("estVerser", false);
    }

    void ReactiverEssence()
    {
        peutVerserEssence = true;
    }





}
