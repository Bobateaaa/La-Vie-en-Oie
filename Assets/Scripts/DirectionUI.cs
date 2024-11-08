using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionUI : MonoBehaviour
{
    public GameObject UIObjet; // 
    public GameObject cameraArriere; // camera en arrière du personnage
    public GameObject cameraAvant; // camera en avant du personnage
    public GameObject cameraHaut; // camera en haut du personnage
    public GameObject cameraVision; // camera qui représente la vision du personnage
     private GameObject activeCamera; // Currently active camera
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


        UIObjet.transform.LookAt(activeCamera.transform);
    }
}
