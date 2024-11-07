using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Fonctionnement et utilité générale du script
    Gestion du déplacement du personnage

   Par : Matilda
   Dernière modification : 01/11/2024
*/


public class DeplacementPersoScript : MonoBehaviour
{
    //Déclaration des variables (publiques, privées et statiques)
    public float vitesseDeplacement = 4f; // vitesse de déplacement
    public float vitesseRotation = 100f; // vitesse de rotation
    private Rigidbody rb; // rigidbody du personnage

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.useGravity = true;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; 
    }

    void FixedUpdate()
    {
        // Get input for movement
        float axeH = Input.GetAxis("Horizontal");
        float axeV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(axeH, 0f, axeV).normalized * vitesseDeplacement * Time.deltaTime;

        rb.MovePosition(transform.position + transform.TransformDirection(movement));

        transform.Rotate(0, axeH * vitesseRotation * Time.deltaTime, 0);

    }
}
