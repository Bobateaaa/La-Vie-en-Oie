using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurNote : MonoBehaviour
{

    public GameObject noteRouge;

    public List<Transform> listePoints;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator genererNotes()
    {
        //temps aleatoire
        yield return new WaitForSeconds(2);

        //Generer chiffre aléatoire
        //Choisis une note en fonction du chiffre
        //Si nombre == 0, generer une note rouge
        // GameObject clone = Instantiate(noteRouge, departNoteRouge.position, departNoteRouge.rotation);
        //Recuperer le rigidbody de la note
        //Ajouter une vitesse

        //Rappeler la coroutine GenererNote
    }
}
