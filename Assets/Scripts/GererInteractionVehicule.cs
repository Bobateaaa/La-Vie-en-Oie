using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GererInteractionVehicule : MonoBehaviour
{
    public GameObject vehicule; // le vehicule
    public GameObject joueur; // le joueur
    public Transform positionVehiculePourAssir; // position du vehicule
    public Transform positionJoueurPourDescendre; // position du joueur
    public bool peutEntrer; // si le joueur peut entrer dans le vehicule
    public bool estAssis; // si le joueur est assis dans le vehicule
    // Start is called before the first frame update
    void Start()
    {
        peutEntrer = false;
        estAssis = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (peutEntrer == true && estAssis == false && Input.GetKeyDown(KeyCode.E))
        {
            joueur.transform.position = positionVehiculePourAssir.position;
            joueur.transform.rotation = positionVehiculePourAssir.rotation;
            estAssis = true;

        } else if (peutEntrer == true && estAssis == true && Input.GetKeyDown(KeyCode.X))
        {
            estAssis = false;
            joueur.transform.position = positionJoueurPourDescendre.position;
        }
        
    }

    void OnTriggerEnter(Collider triggerTrue)
    {
        if (triggerTrue.gameObject.name == "HitboxGoose")
        {
            peutEntrer = true;
        }
    }

    void OnTriggerExit(Collider triggerFalse)
    {
        if (triggerFalse.gameObject.name == "HitboxGoose")
        {
            peutEntrer = false;
        }
    }




    
}
