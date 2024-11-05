using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Fonctionnement et utilité générale du script
   Gestion des caméras du jeu

   Par : Matilda
   Dernière modification : 04/11/2024
*/


public class GestionCamera : MonoBehaviour
{
    //Déclaration des variables (publiques, privées et statiques)
    public GameObject cameraArriere; // camera en arrière du personnage
    public GameObject cameraAvant; // camera en avant du personnage
    public GameObject cameraHaut; // camera en haut du personnage
    public GameObject cameraVision; // camera qui représente la vision du personnage
   

    // Activer une caméra au démarrage du jeu 
    void Start()
    {
        cameraArriere.SetActive(true);
        cameraAvant.SetActive(false);
        cameraHaut.SetActive(false);
        cameraVision.SetActive(false);
        
    }

    // Gérer les caméras en fonction des touches du clavier
    void Update()
    {
        // Si la touche 1 est enfoncée, activer la caméra FPS
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiverCamera(cameraArriere);
        }
        // Si la touche 2 est enfoncée, activer la caméra 3e personne
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiverCamera(cameraAvant);
        }
        // Si la touche 3 est enfoncée, activer la caméra distance fixe
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiverCamera(cameraVision);
        }
        // Si la touche 4 est enfoncée, activer la caméra de surveillance
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActiverCamera(cameraHaut);
        }
        
    }

        // Fonction pour activer la caméra spécifiée
    void ActiverCamera(GameObject cameraChoisi)
    {
        cameraArriere.SetActive(false);
        cameraAvant.SetActive(false);
        cameraHaut.SetActive(false);
        cameraVision.SetActive(false);

        // Activer la caméra spécifiée
        cameraChoisi.SetActive(true);
    }
}
