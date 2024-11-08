using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /* Fonctionnement et utilité générale du script
    Script pour faire les UI regarder dans la direction de la caméra qui est active
    

   Par : Matilda
   Dernière modification : 08/11/2024
   */

public class DirectionUI : MonoBehaviour
{
    public GameObject UIObjet; // 
    public GameObject cameraArriere; // camera en arrière du personnage
    public GameObject cameraAvant; // camera en avant du personnage
    public GameObject cameraHaut; // camera en haut du personnage
    public GameObject cameraVision; // camera qui représente la vision du personnage
    public GameObject cameraVehicule; // camera lorsque le joueur est dans le vehicule
    private GameObject activeCamera; // camera qui est active dans la scene

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cameraArriere.activeSelf)
        {
            activeCamera = cameraArriere;
        }
        else if (cameraAvant.activeSelf)
        {
            activeCamera = cameraAvant;
        }
        else if (cameraHaut.activeSelf)
        {
            activeCamera = cameraHaut;
        }
        else if (cameraVision.activeSelf)
        {
            activeCamera = cameraVision;
        } 
        else if (cameraVehicule.activeSelf)
        {
            activeCamera = cameraVehicule;
        }


        UIObjet.transform.LookAt(activeCamera.transform);
    }
}
