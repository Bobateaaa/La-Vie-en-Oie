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
    public GameObject cameraVehicule; // camera active

    public GameObject vehicule; //
    
    private GererInteractionVehicule scriptVehicule; // script pour gérer les interactions avec le véhicule
   private bool peutEntrerVehicule; // si le personnage peut entrer dans le véhicule
    private bool estAssis; // si le personnage est assis dans le véhicule

    // Activer une caméra au démarrage du jeu 
    void Start()
    {
        scriptVehicule = vehicule.GetComponent<GererInteractionVehicule>();
        cameraArriere.SetActive(true);
        cameraAvant.SetActive(false);
        cameraHaut.SetActive(false);
        cameraVision.SetActive(false);
        cameraVehicule.SetActive(false);
        
    }

    // Gérer les caméras en fonction des touches du clavier
    void Update()
    {
        peutEntrerVehicule = scriptVehicule.peutEntrer;
        estAssis = scriptVehicule.estAssis;

        // Si la touche 1 est enfoncée, activer la caméra arrière
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiverCamera(cameraArriere);
        }
        // Si la touche 2 est enfoncée, activer la caméra avant
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiverCamera(cameraAvant);
        }
        // Si la touche 3 est enfoncée, activer la caméra de vision
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiverCamera(cameraVision);
        }
        // Si la touche 4 est enfoncée, activer la caméra en haut
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActiverCamera(cameraHaut);
        }  
        else if (peutEntrerVehicule == true && estAssis == true)
        {
            ActiverCamera(cameraVehicule);
        }
        
    }

        // Fonction pour activer la caméra spécifiée
    void ActiverCamera(GameObject cameraChoisi)
    {
        cameraArriere.SetActive(false);
        cameraAvant.SetActive(false);
        cameraHaut.SetActive(false);
        cameraVision.SetActive(false);
        cameraVehicule.SetActive(false);

        // Activer la caméra spécifiée
        cameraChoisi.SetActive(true);
    }
}
