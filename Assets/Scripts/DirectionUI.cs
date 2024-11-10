using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
    Gestion de l'orientation de l'UI en fonction de la caméra active

    Par : Matilda
    Dernière modification : 06/11/2024
*/
public class DirectionUI : MonoBehaviour
{
    public GameObject UIObjet; // 
    public GameObject cameraArriere; // camera en arrière du personnage
    public GameObject cameraAvant; // camera en avant du personnage
    public GameObject cameraHaut; // camera en haut du personnage
    public GameObject cameraVision; // camera qui représente la vision du personnage
     private GameObject activeCamera; // camera active
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

        //Le bouton UI est orienté vers la caméra active
        UIObjet.transform.LookAt(activeCamera.transform);
    }
}
