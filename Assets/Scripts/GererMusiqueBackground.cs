using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fonctionnement et utilité générale du script
   Gestion de la musique de fond du jeu

   Par : Matilda
   Dernière modification : 07/11/2024
*/

public class GererMusiqueBackground : MonoBehaviour
{
    AudioSource sourceAudio;
    public AudioClip musiqueJeu;
    // Start is called before the first frame update
    void Start()
    {
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.clip = musiqueJeu;
        sourceAudio.loop = true; 
        sourceAudio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
