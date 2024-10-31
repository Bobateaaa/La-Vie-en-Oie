using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeNote
{
    bleu, rouge, vert, jaune
}

public class Cliquable : MonoBehaviour
{

    public TypeNote type;

void Update()
{
    if(type == TypeNote.bleu && Input.GetKeyDown(KeyCode.A)){
        
    }
}
    void OnMouseEnter()
    {
        // print("Mouse entre.");
    }
    void OnMouseExit()
    {
        // print("Mouse quitte.");
    }
    void OnMouseOver()
    {
        // print("sur l'élément");
    }

    void OnMouseDown()
    {
        
        print("clic");
        gameObject.SetActive(false);
    }
}
