using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Fonctionnement et utilité générale du script
   Gestion des animations du personnage 

   Par : Matilda
   Dernière modification : 02/11/2024
*/


public class AnimationPerso : MonoBehaviour
{
    //Déclaration des variables (publiques, privées et statiques)
    public Animator anim; // animator du personnage

    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetFloat("vitesseVerticale", Input.GetAxis("Vertical"));
        anim.SetFloat("vitesseHorizontale", Input.GetAxis("Horizontal"));

    }
}
